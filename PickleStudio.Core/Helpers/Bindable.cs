using PickleStudio.Core.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PickleStudio.Core.Helpers
{
    public class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        protected T Get<T>([CallerMemberName] string propertyName = null)
        {
            object value = null;
            if (_properties.TryGetValue(propertyName, out value))
                return value == null ? default(T) : (T)value;
            return default(T);
        }

        protected bool Set<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(value, Get<T>(propertyName))) return false;
            _properties[propertyName] = value;
            PropertyChanged.Raise(this, propertyName);
            return true;
        }
    }
}
