using PickleStudio.Core.Interfaces;
using PickleStudio.Extensions;
using PickleStudio.Resources;
using PickleStudio.Views;
using System.Windows.Forms;

namespace PickleStudio.Commands
{
    public class EditorOptionsCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public EditorOptionsCommand(IApplicationState state)
        {
            _state = state;

            Text = Strings.EditorOptionsText;
            Image = Images.EditorOptions;
            Enabled = true;
            ToolTipText = Strings.EditorOptionsToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            var view = new EditorOptionsView(_state.Settings.Editor);
            if (view.ShowDialog() == DialogResult.OK)
            {
                _state.Settings.Editor = view.EditorOptions;
            }
        }
    }
}
