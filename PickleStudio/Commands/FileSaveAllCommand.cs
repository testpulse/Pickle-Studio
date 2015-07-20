using PickleStudio.Core.Interfaces;
using PickleStudio.Properties;
using System.Linq;

namespace PickleStudio.Commands
{
    public class FileSaveAllCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public FileSaveAllCommand(IApplicationState state)
        {
            _state = state;

            Text = Resources.FileSaveAllText;
            Image = Resources.FileSaveAllImage;
            Enabled = false;
            ToolTipText = Resources.FileSaveAllToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            foreach (var feature in _state.Project.Features.Where(f => f.IsChanged))
            {
                feature.Save();
            }
        }
    }
}
