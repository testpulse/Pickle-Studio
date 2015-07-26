using System.Windows.Forms;

namespace PickleStudio.Interfaces
{
    public interface IDialogControl
    {
        string Title { get; }
        IButtonControl AcceptButton { get; }
        IButtonControl CancelButton { get; }
    }
}
