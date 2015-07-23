using PickleStudio.Core.Interfaces;
using PickleStudio.Resources;

namespace PickleStudio.Commands
{
    public class FileSaveCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public FileSaveCommand(IApplicationState state)
        {
            _state = state;

            Text = Strings.FileSaveText;
            Image = Images.FileSave;
            Enabled = false;
            ToolTipText = Strings.FileSaveToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            if (_state.Project.CurrentFeature != null && _state.Project.CurrentFeature.IsChanged)
            {
                _state.Project.CurrentFeature.Save();
            }
        }
    }
}
