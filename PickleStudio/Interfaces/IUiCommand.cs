using PickleStudio.Core.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace PickleStudio.Interfaces
{
    public interface IUiCommand : ICommand
    {
        Bitmap Image { get; set; }
        string Text { get; set; }
        string ToolTipText { get; set; }
        bool CanToggle { get; }
        bool IsToggled { get; }
    }
}
