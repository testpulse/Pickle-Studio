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
        public event EventHandler Saving;
        public event EventHandler Loaded;
        public event PropertyChangedEventHandler EditorSettingsChanged;

        public WindowOptions Window { get; private set; }
        public ProjectOptions Project { get; private set; }
        public EditorOptions Editor { get; private set; }

        public const string FileName = "PickleStudio.settings";

        private readonly Lazy<Serializer> _serializer = new Lazy<Serializer>(() => new Serializer());

        public ApplicationOptions()
        {
            Window = new WindowOptions();
            Project = new ProjectOptions();
            SetEditor(new EditorOptions(), OnEditorPropertyChanged);
        }

        private void OnEditorPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            EditorSettingsChanged.Raise(this, e.PropertyName);
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
            SetEditor(settings.Editor, OnEditorPropertyChanged);

            Loaded.Raise(this);
        }

        private void SetEditor(EditorOptions editor, Action<object, PropertyChangedEventArgs> onPropertyChanged)
        {
            if (Editor != null) Editor.PropertyChanged -= OnEditorPropertyChanged;
            Editor = editor;
            Editor.PropertyChanged += OnEditorPropertyChanged;
        }
    }
}
