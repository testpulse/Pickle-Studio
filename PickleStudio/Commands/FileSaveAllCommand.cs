using PickleStudio.Core.Interfaces;
using PickleStudio.Resources;
using System.Linq;

namespace PickleStudio.Commands
{
    public class FileSaveAllCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public FileSaveAllCommand(IApplicationState state)
        {
            _state = state;

            Text = Strings.FileSaveAllText;
            Image = Images.FileSaveAll;
            Enabled = false;
            ToolTipText = Strings.FileSaveAllToolTipText;
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
