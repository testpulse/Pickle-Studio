using System.ComponentModel;
using System.Drawing;

namespace PickleStudio.Core.Interfaces
{
    public interface ICommand : INotifyPropertyChanged
    {
        bool Enabled { get; set; }
        void Execute(params string[] args);
    }
}
