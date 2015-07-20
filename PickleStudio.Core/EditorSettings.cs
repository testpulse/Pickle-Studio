using PickleStudio.Core.Helpers;

namespace PickleStudio.Core
{
    public class EditorSettings : Bindable
    {
        public bool WordWrap
        {
            get { return Get<bool>(); }
            set { Set(value); } 
        }

        public bool DisplayLineNumbers
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }

        public bool DisplaySymbols
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }

        public EditorSettings()
        {
            WordWrap = false;
            DisplayLineNumbers = true;
            DisplaySymbols = false;
        }
    }
}
