using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace PickleStudio.Extensions
{
    public static class StringExtensions
    {
        public static double ToFontSize(this string fontSize)
        {
            var fontSizeConverter = new FontSizeConverter();
            return (double)fontSizeConverter.ConvertFromString(fontSize);
        }

        public static IEnumerable<string> ReadLines(this string s)
        {
            string line;
            using (var sr = new StringReader(s))
                while ((line = sr.ReadLine()) != null)
                    yield return line;
        }
    }
}
