using PickleStudio.Core.Extensions;
using PickleStudio.Core.Helpers;
using System.Windows;
using System.Windows.Media;

namespace PickleStudio.Core.Options
{
    public class EditorOptions : Bindable
    {
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public FontOptions FontOptions { get; set; }
        public FontOptions CommentFontOptions { get; set; }
        public FontOptions TagFontOptions { get; set; }
        public FontOptions ParametersFontOptions { get; set; }
        public FontOptions StringsFontOptions { get; set; }
        public FontOptions TableFontOptions { get; set; }
        public FontOptions FeatureKeywordFontOptions { get; set; }
        public FontOptions StepKeywordFontOptions { get; set; }
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

        public EditorOptions()
        {
            FontFamily = "Consolas";
            FontSize = "10pt";
            FontOptions = new FontOptions();
            CommentFontOptions = new FontOptions { TextColor = Colors.Green };
            TagFontOptions = new FontOptions { TextColor = Colors.Teal, Style = FontStyles.Italic };
            ParametersFontOptions = new FontOptions { TextColor = Colors.Gray };
            StringsFontOptions = new FontOptions { TextColor = Colors.Gray };
            TableFontOptions = new FontOptions { TextColor = Colors.Maroon };
            FeatureKeywordFontOptions = new FontOptions { TextColor = Colors.DarkBlue, Weight = FontWeights.Bold };
            StepKeywordFontOptions = new FontOptions { TextColor = Colors.Blue, Weight = FontWeights.Bold };
            WordWrap = false;
            DisplayLineNumbers = true;
            DisplaySymbols = false;
        }
    }
}
