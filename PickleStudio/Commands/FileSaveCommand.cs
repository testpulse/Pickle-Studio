using PickleStudio.Core.Interfaces;
using PickleStudio.Properties;

namespace PickleStudio.Commands
{
    public class FileSaveCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public FileSaveCommand(IApplicationState state)
        {
            _state = state;

            Text = Resources.FileSaveText;
            Image = Resources.FileSaveImage;
            Enabled = false;
            ToolTipText = Resources.FileSaveToolTipText;
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
