using System;
using System.Drawing;
using PickleStudio.Core.Extensions;

namespace PickleStudio.Commands
{
    public class ToggleCommand : DelegateCommand
    {
        private Func<bool> _getter;

        public override bool CanToggle
        {
            get { return true; }
        }

        public override bool IsToggled
        {
            get { return _getter(); }
        }

        public ToggleCommand(Func<bool> getter, Action<bool> setter, string text = "", Bitmap image = null, string toolTipText = "", bool enabled = true)
            : base(() => setter(!getter()), text, image, toolTipText, enabled)
        {
            _getter = getter;
        }
    }
}
