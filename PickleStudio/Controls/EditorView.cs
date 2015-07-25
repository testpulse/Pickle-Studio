using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Folding;
using PickleStudio.Core;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using PickleStudio.Editor.CodeCompletion;
using PickleStudio.Editor.Folding;
using PickleStudio.Editor.Highlighting;
using PickleStudio.Extensions;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Media;

namespace PickleStudio.Controls
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
            _editor.SyntaxHighlighting = new GherkinHighlightingDefinition();

            // make customisable
            _editor.FontFamily = new FontFamily("Consolas");
            _editor.FontSize = "10pt".ToFontSize();

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
            // we could only set values when they changed but the obvious way requires magic strings.  It might be possible to use C# property name features instead.
            ApplySettings();
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

        public void ApplySettings()
        {
            _editor.WordWrap = _state.Settings.Editor.WordWrap;
            _editor.ShowLineNumbers = _state.Settings.Editor.DisplayLineNumbers;
            var displaySymbols = _state.Settings.Editor.DisplaySymbols;
            _editor.Options.ShowBoxForControlCharacters = displaySymbols;
            _editor.Options.ShowTabs = displaySymbols;
            _editor.Options.ShowSpaces = displaySymbols;
            _editor.Options.ShowEndOfLine = displaySymbols;
        }
    }
}
