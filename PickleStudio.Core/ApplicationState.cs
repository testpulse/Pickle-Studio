using PickleStudio.Core.Interfaces;
using System;

namespace PickleStudio.Core
{
    public class ApplicationState : IApplicationState
    {
        public Settings Settings { get; private set; }
        public Project Project { get; private set; }
        public IEditor Editor { get; private set; }
        public ITestViewer TestViewer { get; private set; }

        public ApplicationState()
        {
            Settings = new Settings();
            Project = new Project();
        }

        public void RegisterEditor(IEditor editor)
        {
            Editor = editor;
        }

        public void RegisterTestViewer(ITestViewer testViewer)
        {
            TestViewer = testViewer;
        }
    }
}
