using System;
using System.Drawing;

namespace PickleStudio.Commands
{
    public class DelegateCommand : AbstractUiCommand
    {    
        private readonly Action _executor;

        public DelegateCommand(Action executor, string text = "", Bitmap image = null, string toolTipText = "", bool enabled = true)
        {
            _executor = executor;
            Text = text;
            Image = image;
            Enabled = enabled;
            ToolTipText = toolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            if (_executor != null) _executor();
        }
    }
}
