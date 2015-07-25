using PickleStudio.Core.Interfaces;
using PickleStudio.Core.Options;
using System;

namespace PickleStudio.Core
{
    public class ApplicationState : IApplicationState
    {
        public ApplicationOptions Settings { get; private set; }
        public Project Project { get; private set; }
        public IEditor Editor { get; private set; }
        public ITestViewer TestViewer { get; private set; }

        public ApplicationState()
        {
            Settings = new ApplicationOptions();
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
