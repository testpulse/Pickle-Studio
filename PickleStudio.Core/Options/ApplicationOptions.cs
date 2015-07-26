using PickleStudio.Core.Commands;
using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using System;
using System.ComponentModel;
using System.IO;

namespace PickleStudio.Core.Options
{
    [Serializable]
    public class ApplicationOptions
    {
        public const string FileName = "PickleStudio.settings";

        public event EventHandler Saving;
        public event EventHandler Loaded;
        public event PropertyChangedEventHandler EditorSettingsChanged;

        private readonly Lazy<Serializer> _serializer = new Lazy<Serializer>(() => new Serializer());

        private EditorOptions _editor;

        public WindowOptions Window { get; private set; }
        public ProjectOptions Project { get; private set; }
        public EditorOptions Editor {
            get { return _editor; }
            set { SetEditor(value); }
        }

        public ApplicationOptions()
        {
            Window = new WindowOptions();
            Project = new ProjectOptions();
            Editor = new EditorOptions();
        }

        public void Save()
        {
            Saving.Raise(this);

            _serializer.Value.SerializeToFile(this, FileName);
        }

        public void Load()
        {
            var settings = (File.Exists(FileName)) ?
                _serializer.Value.DeserializeFromFile<ApplicationOptions>(FileName) :
                new ApplicationOptions();

            Window = settings.Window;
            Project = settings.Project;
            Editor = settings.Editor;

            Loaded.Raise(this);
        }

        public void SetEditor(EditorOptions editor)
        {
            if (_editor != null) _editor.PropertyChanged -= OnEditorPropertyChanged;
            _editor = editor;
            _editor.PropertyChanged += OnEditorPropertyChanged;
            Command.EditorWordWrap.Sync();
            Command.EditorDisplayLineNumbers.Sync();
            Command.EditorDisplaySymbols.Sync();
            EditorSettingsChanged.Raise(this, "");
        }

        public void OnEditorPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EditorSettingsChanged.Raise(this, e.PropertyName);
        }
    }
}
