using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using PickleStudio.Core.Extensions;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;

namespace PickleStudio.Editor.Highlighting
{
    public static class HighlightingExtensions
    {
        public static IHighlightingDefinition ToHighlightingDefinition(this byte[] bytes)
        {
            using (var reader = bytes.ToXmlReader())
            {
                return HighlightingLoader.Load(reader, HighlightingManager.Instance);
            }
        }

        public static HighlightingColor ToHighlightingColor(this Color color, FontWeight? fontWeight = null)
        {
            return new HighlightingColor
            {
                Foreground = new SimpleHighlightingBrush(color),
                FontWeight = fontWeight
            };
        }

        public static Regex ToRegex(this string expression)
        {
            return new Regex(expression, RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Compiled);
        }
    }
}
