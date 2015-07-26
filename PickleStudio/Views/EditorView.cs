using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Folding;
using PickleStudio.Core;
using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using PickleStudio.Editor.CodeCompletion;
using PickleStudio.Editor.Folding;
using PickleStudio.Editor.Highlighting;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Media;

namespace PickleStudio.Views
{
    public partial class EditorView : UserControl, IEditor
    {
        private readonly IApplicationState _state;
        private readonly TextEditor _editor;

        public Feature Feature { get { return _state.Project.CurrentFeature; } }

        public EditorView(IApplicationState state)
        {
            InitializeComponent();

            _state = state;

            _editor = new TextEditor();
            _editor.Name = "txtEditor";
            _editor.IsReadOnly = true;
            _editor.Options.EnableEmailHyperlinks = false;
            _editor.Options.EnableHyperlinks = false;
            _editor.TextChanged += OnTextChanged;

            ehoEditor.Child = _editor;

            // folding
            var foldingManager = FoldingManager.Install(_editor.TextArea);
            var foldingStrategy = new GherkinFoldingStrategy();
            Timer foldingTimer = new Timer { Interval = TimeSpan.FromSeconds(2).Seconds };
            foldingTimer.Tick += (s, e) => foldingStrategy.UpdateFoldings(foldingManager, _editor.Document);
            foldingTimer.Start();

            // code completion
            var codeCompletionStrategy = new GherkinCodeCompletionStrategy(_editor, state);

            state.Project.CurrentFeatureChanged += OnCurrentFeatureChanged;
            state.Settings.EditorSettingsChanged += OnEditorSettingsChanged;
        }

        private void OnEditorSettingsChanged(object sender, PropertyChangedEventArgs e)
        {
            ApplySettings(e.PropertyName);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (Feature == null) return;

            Feature.Content = _editor.Text;
        }

        private void OnCurrentFeatureChanged(object sender, EventArgs<Feature> e)
        {
            _editor.Text = (e.Item != null) ? e.Item.Content : string.Empty;
            _editor.IsReadOnly = (e.Item == null);
        }

        public void Copy()
        {
            _editor.Copy();
        }

        public void Cut()
        {
            _editor.Cut();
        }

        public void Paste()
        {
            _editor.Paste();
        }

        public void Undo()
        {
            _editor.Undo();
        }

        public void Redo()
        {
            _editor.Redo();
        }

        public void ApplySettings(string propertyName = "")
        {
            var applyAll = string.IsNullOrEmpty(propertyName);
            if (applyAll)
            {
                _editor.FontFamily = new FontFamily(_state.Settings.Editor.FontFamily);
                _editor.FontSize = _state.Settings.Editor.FontSize.ToFontSize();
                _editor.Background = new SolidColorBrush(_state.Settings.Editor.FontOptions.BackgroundColor);
                _editor.Foreground = new SolidColorBrush(_state.Settings.Editor.FontOptions.TextColor);
                _editor.FontWeight = _state.Settings.Editor.FontOptions.Weight;
                _editor.FontStyle = _state.Settings.Editor.FontOptions.Style;
                _editor.SyntaxHighlighting = new GherkinHighlightingDefinition(_state.Settings.Editor);
            }
            if (applyAll || propertyName == "WordWrap")
            {
                _editor.WordWrap = _state.Settings.Editor.WordWrap;
            }
            if (applyAll || propertyName == "DisplayLineNumbers")
            {
                _editor.ShowLineNumbers = _state.Settings.Editor.DisplayLineNumbers;
            }
            if (applyAll || propertyName == "DisplaySymbols")
            {
                var displaySymbols = _state.Settings.Editor.DisplaySymbols;
                _editor.Options.ShowBoxForControlCharacters = displaySymbols;
                _editor.Options.ShowTabs = displaySymbols;
                _editor.Options.ShowSpaces = displaySymbols;
                _editor.Options.ShowEndOfLine = displaySymbols;
            }
        }
    }
}
