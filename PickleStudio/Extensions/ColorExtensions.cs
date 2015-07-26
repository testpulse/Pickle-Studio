
namespace PickleStudio.Extensions
{
    public static class ColorExtensions
    {
        public static System.Drawing.Color ToWinFormsColor(this System.Windows.Media.Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
        public static System.Windows.Media.Color ToWpfColor(this System.Drawing.Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
