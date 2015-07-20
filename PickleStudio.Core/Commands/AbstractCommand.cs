using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using System.ComponentModel;

namespace PickleStudio.Core.Commands
{
    public abstract class AbstractCommand : Bindable, ICommand, INotifyPropertyChanged
    {
        public bool Enabled
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }

        public abstract void Execute(params string[] args);
    }
}
