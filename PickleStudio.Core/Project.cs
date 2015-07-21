using Microsoft.Build.Evaluation;
using NUnit.Core;
using PickleStudio.Core.Commands;
using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

using TestRunner = PickleStudio.Core.Helpers.TestRunner;

namespace PickleStudio.Core
{
    public class Project : Bindable
    {
        private const string NoProjectName = "No Project";

        public event EventHandler<EventArgs<Project>> ProjectOpened;
        public event EventHandler<EventArgs<Project, Feature>> FeatureOpened;
        public event EventHandler<EventArgs<Feature>> CurrentFeatureChanged;
        public event EventHandler<EventArgs<Feature>> FeatureContentChanged;
        public event EventHandler<EventArgs<Feature>> FeatureSaved;
        public event EventHandler<EventArgs<Exception>> TestRunFinishedWithException;
        public event EventHandler<EventArgs<TestResult>> TestRunFinishedWithResult;
        public event EventHandler<EventArgs<string, int>> TestRunStarted;
        public event EventHandler<EventArgs<TestResult>> TestSuiteFinished;
        public event EventHandler<EventArgs<TestName>> TestSuiteStarted;
        public event EventHandler<EventArgs<TestResult>> TestFinished;
        public event EventHandler<EventArgs<TestOutput>> TestOutput;
        public event EventHandler<EventArgs<TestName>> TestStarted;
        public event EventHandler<EventArgs<Exception>> TestUnhandledException;

        public string Name { get; set; }
        public string FilePath { get; set; }
        public List<Feature> Features { get; set; }

        public Feature CurrentFeature {
            get { return Get<Feature>(); }
            set { Set(value); } 
        }
        public bool IsChanged { get { return Features.Any(f => f.IsChanged); } }

        public Project()
        {
            Name = NoProjectName;
            FilePath = string.Empty;
            Features = new List<Feature>();
            PropertyChanged += OnPropertyChanged;
        }

        public IEnumerable<string> GetOpenedFilePaths()
        {
            if (Name == NoProjectName)
            {
                return Features.Select(f => f.FilePath);
            }
            else if (!string.IsNullOrEmpty(FilePath))
            {
                return new List<string> { FilePath };
            }
            return new List<string>();
        }

        public void Open(string filePath)
        {
            var isFeature = filePath.IsFeature();
            if (isFeature)
            {
                var feature = new Feature(filePath, OnFeatureContentChanged, OnFeatureSaved);
                if (Name == NoProjectName)
                {
                    var existingFeatureIndex = Features.FindIndex(f => f.FilePath == filePath);
                    if (existingFeatureIndex >= 0)
                    {
                        Features[existingFeatureIndex] = feature;
                    }
                    else
                    {
                        Features.Add(feature);
                    }
                    FeatureOpened.Raise(this, this, feature);
                    return;
                }
                else
                {
                    Name = NoProjectName;
                    FilePath = string.Empty;
                    Features = new List<Feature> { feature };
                }
            }
            else
            {
                Name = Path.GetFileNameWithoutExtension(filePath);
                FilePath = filePath;
                var project = GetProject(filePath);
                Features = project.Items
                    .Where(i => i.EvaluatedInclude.IsFeature())
                    .Select(i => new Feature(Path.Combine(project.DirectoryPath, i.EvaluatedInclude), OnFeatureContentChanged, OnFeatureSaved))
                    .ToList();
            }
            Command.TestRun.SetEnabled(Name != NoProjectName);
            ProjectOpened.Raise(this, this);
        }

        public void RunTests()
        {
            var project = GetProject(FilePath);
            var targetPath = project.GetPropertyValue("TargetPath");

            var eventListener = new TestRunnerListener(
                (i) => TestRunFinishedWithException.Raise(this, i),
                (i) => TestRunFinishedWithResult.Raise(this, i),
                (i, j) => TestRunStarted.Raise(this, i, j),
                (i) => TestSuiteFinished.Raise(this, i),
                (i) => TestSuiteStarted.Raise(this, i),
                (i) => TestFinished.Raise(this, i),
                (i) => TestOutput.Raise(this, i),
                (i) => TestStarted.Raise(this, i),
                (i) => TestUnhandledException.Raise(this, i));
            var testRunner = new TestRunner(targetPath, eventListener);
            testRunner.Run();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CurrentFeature")
            {
                var canEdit = CurrentFeature != null;
                Command.EditCopy.SetEnabled(canEdit);
                Command.EditCut.SetEnabled(canEdit);
                Command.EditPaste.SetEnabled(canEdit);
                Command.EditUndo.SetEnabled(canEdit);
                Command.EditRedo.SetEnabled(canEdit);
                CurrentFeatureChanged.Raise(this, CurrentFeature);
            }
        }

        private void OnFeatureContentChanged(object sender, EventArgs e)
        {
            Command.FileSave.SetEnabled(IsChanged);
            Command.FileSaveAll.SetEnabled(IsChanged);
            FeatureContentChanged.Raise(this, (Feature)sender);
        }

        private void OnFeatureSaved(object sender, EventArgs e)
        {
            Command.FileSave.SetEnabled(IsChanged);
            Command.FileSaveAll.SetEnabled(IsChanged);
            FeatureSaved.Raise(this, (Feature)sender);
        }

        private Microsoft.Build.Evaluation.Project GetProject(string filePath)
        {
            var project = 
                ProjectCollection.GlobalProjectCollection.LoadedProjects.FirstOrDefault(p => p.FullPath == filePath) ??
                ProjectCollection.GlobalProjectCollection.LoadProject(filePath);

            return project;
        }
    }
}
