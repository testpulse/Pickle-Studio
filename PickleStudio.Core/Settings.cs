using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using System;
using System.ComponentModel;
using System.IO;

namespace PickleStudio.Core
{
    [Serializable]
    public class Settings
    {
        public event EventHandler Saving;
        public event EventHandler Loaded;
        public event PropertyChangedEventHandler EditorSettingsChanged;

        public WindowSettings Window { get; private set; }
        public ProjectSettings Project { get; private set; }
        public EditorSettings Editor { get; private set; }

        public const string FileName = "PickleStudio.settings";

        private readonly Lazy<Serializer> _serializer = new Lazy<Serializer>(() => new Serializer());

        public Settings()
        {
            Window = new WindowSettings();
            Project = new ProjectSettings();
            SetEditor(new EditorSettings(), OnEditorPropertyChanged);
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
                _serializer.Value.DeserializeFromFile<Settings>(FileName) :
                new Settings();

            Window = settings.Window;
            Project = settings.Project;
            SetEditor(settings.Editor, OnEditorPropertyChanged);

            Loaded.Raise(this);
        }

        private void SetEditor(EditorSettings editor, Action<object, PropertyChangedEventArgs> onPropertyChanged)
        {
            if (Editor != null) Editor.PropertyChanged -= OnEditorPropertyChanged;
            Editor = editor;
            Editor.PropertyChanged += OnEditorPropertyChanged;
        }
    }
}
