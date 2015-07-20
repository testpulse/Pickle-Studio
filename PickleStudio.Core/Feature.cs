using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using System;
using System.ComponentModel;
using System.IO;

namespace PickleStudio.Core
{
    public class Feature : Bindable
    {
        public event EventHandler Saved;
        public event EventHandler ContentChanged;

        public string Name { get; set; }
        public string FilePath { get; set; }

        public string Content
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public bool IsChanged { get; private set; }

        public Feature(string filePath, EventHandler onFeatureContentChanged, EventHandler onFeatureSaved)
        {
            Name = Path.GetFileNameWithoutExtension(filePath);
            FilePath = filePath;
            Content = File.ReadAllText(filePath);
            PropertyChanged += OnPropertyChanged;
            ContentChanged += onFeatureContentChanged;
            Saved += onFeatureSaved;
        }

        public void Save()
        {
            File.WriteAllText(FilePath, Content);
            IsChanged = false;
            Saved.Raise(this);
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Content")
            {
                IsChanged = true;
                ContentChanged.Raise(sender);
            }
        }
    }
}
