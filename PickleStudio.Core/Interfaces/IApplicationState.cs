using PickleStudio.Core;
using System;

namespace PickleStudio.Core.Interfaces
{
    public interface IApplicationState
    {
        Settings Settings { get; }
        Project Project { get; }
        IEditor Editor { get; }
        ITestViewer TestViewer { get; }

        void RegisterEditor(IEditor editor);
        void RegisterTestViewer(ITestViewer testViewer);
    }
}
