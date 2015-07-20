using PickleStudio.Commands;
using PickleStudio.Controls;
using PickleStudio.Core;
using PickleStudio.Core.Commands;
using PickleStudio.Core.Interfaces;
using PickleStudio.Extensions;
using PickleStudio.Properties;
using System;
using System.Windows.Forms;

namespace PickleStudio
{
    public partial class MainForm : Form
    {
        private readonly Lazy<IApplicationState> _state = new Lazy<IApplicationState>(() => new ApplicationState());

        public IApplicationState State { get { return _state.Value; } }

        private ProjectView _projectView;
        private EditorView _editorView;
        //private OutputView _outputView;
        //private TestView _testView;

        public MainForm()
        {
            InitializeComponent();

            Text = Resources.MainTitle;
            splitContainer1.Panel2Collapsed = true;

            RegisterCommands();

            CreateViews();

            LoadSettings();

            SubscribeToEvents();

            CreateToolBars();
        }

        private void RegisterCommands()
        {
            Command.FileOpen.Register(new FileOpenCommand(State));
            Command.FileSave.Register(new FileSaveCommand(State));
            Command.FileSaveAll.Register(new FileSaveAllCommand(State));
            Command.SettingsLoad.Register(new DelegateCommand(() => State.Settings.Load(), Resources.SettingsLoadText, null, Resources.SettingsLoadToolTipText));
            Command.SettingsSave.Register(new DelegateCommand(() => State.Settings.Save(), Resources.SettingsSaveText, null, Resources.SettingsSaveToolTipText));
            Command.EditCopy.Register(new DelegateCommand(() => State.Editor.Copy(), Resources.EditCopyText, Resources.EditCopyImage, Resources.EditCopyToolTipText, false));
            Command.EditCut.Register(new DelegateCommand(() => State.Editor.Cut(), Resources.EditCutText, Resources.EditCutImage, Resources.EditCutToolTipText, false));
            Command.EditPaste.Register(new DelegateCommand(() => State.Editor.Paste(), Resources.EditPasteText, Resources.EditPasteImage, Resources.EditPasteToolTipText, false));
            Command.EditUndo.Register(new DelegateCommand(() => State.Editor.Undo(), Resources.EditUndoText, Resources.EditUndoImage, Resources.EditUndoToolTipText, false));
            Command.EditRedo.Register(new DelegateCommand(() => State.Editor.Redo(), Resources.EditRedoText, Resources.EditRedoImage, Resources.EditRedoToolTipText, false));
            Command.EditorWordWrap.Register(new ToggleCommand(() => State.Settings.Editor.WordWrap, (a) => State.Settings.Editor.WordWrap = a, Resources.EditorWordWrapText, Resources.EditorWordWrapImage, Resources.EditorWordWrapToolTipText));
            Command.EditorDisplayLineNumbers.Register(new ToggleCommand(() => State.Settings.Editor.DisplayLineNumbers, (a) => State.Settings.Editor.DisplayLineNumbers = a, Resources.EditorDisplayLineNumbersText, Resources.EditorDisplayLineNumbersImage, Resources.EditorDisplayLineNumbersToolTipText));
            Command.EditorDisplaySymbols.Register(new ToggleCommand(() => State.Settings.Editor.DisplaySymbols, (a) => State.Settings.Editor.DisplaySymbols = a, Resources.EditorDisplaySymbolsText, Resources.EditorDisplaySymbolsImage, Resources.EditorDisplaySymbolsToolTipText));
            Command.HelpAbout.Register(new DelegateCommand(() => new AboutView().ShowDialog(), Resources.HelpAboutText, Resources.HelpAboutImage, Resources.HelpAboutToolTipText));
            Command.TestRun.Register(new TestRunCommand(State));
        }

        private void CreateViews()
        {
            _projectView = new ProjectView(State);
            splitContainer2.Panel1.Controls.Add(_projectView);
            _projectView.Dock = DockStyle.Fill;

            _editorView = new EditorView(State);
            splitContainer2.Panel2.Controls.Add(_editorView);
            _editorView.Dock = DockStyle.Fill;
            State.RegisterEditor(_editorView);

            //_testView = new TestView();
            //tbpTest.Controls.Add(_testView);
            //_testView.Dock = DockStyle.Fill;
            //State.RegisterTestViewer(_testView);

            //_outputView = new OutputView();
            //tbpOutput.Controls.Add(_outputView);
            //_outputView.Dock = DockStyle.Fill;
        }

        private void CreateToolBars()
        {
            // build in opposite to desired order becauses it's a pain to re-arrange these things.  Need to revisit.
            tscMain
                .AddToolStrip(Command.HelpAbout)
                .AddToolStrip(Command.EditorWordWrap, Command.EditorDisplayLineNumbers, Command.EditorDisplaySymbols)
                .AddToolStrip(Command.EditCopy, Command.EditCut, Command.EditPaste, Command.None, Command.EditUndo, Command.EditRedo)
                .AddToolStrip(Command.FileOpen, Command.FileSave, Command.FileSaveAll);
        }

        private void LoadSettings()
        {
            State.Settings.Loaded += OnSettingsLoaded;
            State.Settings.Saving += OnSettingsSaving;

            Command.SettingsLoad.Execute();
        }

        private void SubscribeToEvents()
        {
            SizeChanged += (s, e) => 
            {
                State.Settings.Window.Height = (WindowState == FormWindowState.Normal) ? Height : RestoreBounds.Height;
                State.Settings.Window.Width = (WindowState == FormWindowState.Normal) ? Width : RestoreBounds.Width;
                State.Settings.Window.WindowState = WindowState; 
            };
            splitContainer1.SplitterMoved += (s, e) => State.Settings.Window.BottomPanelHeight = splitContainer1.Panel2.Height;
            splitContainer2.SplitterMoved += (s, e) => State.Settings.Window.LeftPanelWidth = splitContainer2.Panel1.Width;
        }

        private void OnSettingsSaving(object sender, EventArgs e)
        {
            State.Settings.Project.OpenedFilePaths = State.Project.GetOpenedFilePaths();
        }

        private void OnSettingsLoaded(object sender, EventArgs e)
        {
            Width = State.Settings.Window.Width;
            Height = State.Settings.Window.Height;
            WindowState = State.Settings.Window.WindowState;
            splitContainer1.SplitterDistance = splitContainer1.Height - splitContainer1.SplitterWidth - State.Settings.Window.BottomPanelHeight;
            splitContainer2.SplitterDistance = State.Settings.Window.LeftPanelWidth;

            foreach (var filePath in State.Settings.Project.OpenedFilePaths)
            {
                Command.FileOpen.Execute(filePath);
            }

            _editorView.ApplySettings();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Command.SettingsSave.Execute();
        }
    }
}
