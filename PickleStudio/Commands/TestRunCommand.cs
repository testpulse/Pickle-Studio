using PickleStudio.Core.Interfaces;
using PickleStudio.Properties;

namespace PickleStudio.Commands
{
    public class TestRunCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public TestRunCommand(IApplicationState state)
        {
            _state = state;

            Text = Resources.TestRunText;
            Image = Resources.TestRunImage;
            Enabled = false;
            ToolTipText = Resources.TestRunToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            _state.Project.RunTests();
        }
    }
}
