using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using PickleStudio.Core;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace PickleStudio.Editor.CodeCompletion
{
    public class GherkinCodeCompletionStrategy : ICodeCompletionStrategy
    {
        private static readonly List<string> _keywords = Gherkin.FunctionKeywords.Concat(Gherkin.ReservedKeywords).ToList();
        private static readonly List<string> _keywordActivators = _keywords.Select(k => k[0].ToString()).Distinct().ToList();

        private readonly TextEditor _editor;
        private readonly CodeCompletionProjectSteps _steps = new CodeCompletionProjectSteps();

        private CompletionWindow _completionWindow = null;

        public GherkinCodeCompletionStrategy(TextEditor editor, IApplicationState state)
        {
            _editor = editor;

            state.Project.ProjectOpened += OnProjectOpened;
            state.Project.FeatureOpened += OnFeatureUpdate;
            state.Project.FeatureSaved += OnFeatureUpdate;

            editor.TextArea.TextEntered += OnTextEntered;
            editor.TextArea.TextEntering += OnTextEntering;
        }

        private void OnProjectOpened(object sender, EventArgs<Project> e)
        {
            _steps.ClearSteps();
            foreach (var feature in e.Item.Features)
            {
                _steps.RefreshSteps(feature);
            }
        }

        private void OnFeatureUpdate(object sender, EventArgs<Feature> e)
        {
            _steps.RefreshSteps(e.Item);
        }

        private void OnTextEntered(object sender, TextCompositionEventArgs e)
        {
            if (_completionWindow != null && _completionWindow.CompletionList.ListBox.SelectedItems.Count > 0 && e.Text != " ") return;

            HideCompletionWindow();
            OnGivenWhenThenActivator(_steps);
        }

        private void OnTextEntering(object sender, TextCompositionEventArgs e)
        {
            if (_completionWindow != null) return;
            if (_keywordActivators.Contains(e.Text)) OnKeywordActivator(_keywords);
        }

        private void ShowCompletionWindow(IEnumerable<string> data)
        {
            _completionWindow = new CompletionWindow(_editor.TextArea);
            _completionWindow.CloseWhenCaretAtBeginning = true;
            _completionWindow.SizeToContent = SizeToContent.WidthAndHeight;
            foreach (var item in data)
            {
                _completionWindow.CompletionList.CompletionData.Add(new CodeCompletionData(item));
            }
            _completionWindow.Show();
            _completionWindow.Closed += (a, b) => { _completionWindow = null; };
        }

        private void HideCompletionWindow()
        {
            if (_completionWindow == null) return;
            _completionWindow.Close();
            _completionWindow = null;
        }

        private void OnKeywordActivator(List<string> keywords)
        {
            var caretOffset = _editor.CaretOffset;
            var line = _editor.Document.GetLineByOffset(caretOffset);
            var lineText = _editor.Document.GetText(line.Offset, caretOffset - line.Offset);
            if (string.IsNullOrWhiteSpace(lineText)) ShowCompletionWindow(keywords);
        }

        private void OnGivenWhenThenActivator(CodeCompletionProjectSteps steps)
        {
            var caretOffset = _editor.CaretOffset;
            var line = _editor.Document.GetLineByOffset(caretOffset);
            var type = _editor.Document.GetText(line.Offset, caretOffset - line.Offset - 1).Trim();
            if (type == Gherkin.And || type == Gherkin.But) type = GetContinuationType(line.PreviousLine);
            if (type == Gherkin.Given) ShowCompletionWindow(_steps.Givens);
            else if (type == Gherkin.When) ShowCompletionWindow(_steps.Whens);
            else if (type == Gherkin.Then) ShowCompletionWindow(_steps.Thens);
        }

        private string GetContinuationType(DocumentLine line)
        {
            if (line == null) return string.Empty;
            var text = _editor.Document.GetText(line).TrimStart();
            if (text.StartsWith(Gherkin.Given)) return Gherkin.Given;
            if (text.StartsWith(Gherkin.When)) return Gherkin.When;
            if (text.StartsWith(Gherkin.Then)) return Gherkin.Then;
            if (Gherkin.FunctionKeywords.Any(f => text.StartsWith(f))) return string.Empty;
            return GetContinuationType(line.PreviousLine);
        }
    }
}
