using PickleStudio.Core.Interfaces;
using PickleStudio.Resources;

namespace PickleStudio.Commands
{
    public class TestRunCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public TestRunCommand(IApplicationState state)
        {
            _state = state;

            Text = Strings.TestRunText;
            Image = Images.TestRun;
            Enabled = false;
            ToolTipText = Strings.TestRunToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            _state.Project.RunTests();
        }
    }
}
