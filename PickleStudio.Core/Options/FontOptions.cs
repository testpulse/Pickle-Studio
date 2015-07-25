using System.Windows;
using System.Windows.Media;

namespace PickleStudio.Core.Options
{
    public class FontOptions
    {
        public Color TextColor { get; set; }
        public Color BackgroundColor { get; set; }
        public FontWeight Weight { get; set; }
        public FontStyle Style { get; set; }
        public bool Underline { get; set; }

        public FontOptions()
        {
            TextColor = Colors.Black;
            BackgroundColor = Colors.White;
            Weight = FontWeights.Normal;
            Style = FontStyles.Normal;
            Underline = false;
        }
    }
}
