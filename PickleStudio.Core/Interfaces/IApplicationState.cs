using PickleStudio.Core.Options;

namespace PickleStudio.Core.Interfaces
{
    public interface IApplicationState
    {
        ApplicationOptions Settings { get; }
        Project Project { get; }
        IEditor Editor { get; }
        ITestViewer TestViewer { get; }

        void RegisterEditor(IEditor editor);
        void RegisterTestViewer(ITestViewer testViewer);
    }
}
