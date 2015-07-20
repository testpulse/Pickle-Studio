using System;

namespace PickleStudio.Core.Helpers
{
    public class EventArgs<T> : EventArgs
    {
        public T Item { get; private set; }

        public EventArgs(T item)
        {
            Item = item;
        }
    }
    public class EventArgs<T1, T2> : EventArgs
    {
        public T1 Item1 { get; private set; }
        public T2 Item2 { get; private set; }

        public EventArgs(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
