using System.IO;

namespace PickleStudio.Core.Extensions
{
    public static class StringExtensions
    {

        public static bool IsFeature(this string filePath)
        {
            return Path.GetExtension(filePath) == ".feature";
        }
    }
}
