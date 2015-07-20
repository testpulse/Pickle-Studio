using PickleStudio.Core.Helpers;
using System;
using System.ComponentModel;

namespace PickleStudio.Core.Extensions
{
    public static class EventHandlerExtensions
    {
        public static void Raise(this EventHandler handler, object sender, EventArgs args = null)
        {
            if (handler != null)
            {
                handler(sender, args ?? EventArgs.Empty);
            }
        }

        public static void Raise(this PropertyChangedEventHandler handler, object sender, string propertyName)
        {
            if (handler != null)
            {
                handler(sender, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static void Raise<T>(this EventHandler<EventArgs<T>> handler, object sender, T item)
        {
            if (handler != null)
            {
                handler(sender, new EventArgs<T>(item));
            }
        }

        public static void Raise<T1, T2>(this EventHandler<EventArgs<T1, T2>> handler, object sender, T1 item1, T2 item2)
        {
            if (handler != null)
            {
                handler(sender, new EventArgs<T1, T2>(item1, item2));
            }
        }
    }
}
