using System.Windows.Forms;

namespace PickleStudio.Core.Options
{
    public class WindowOptions
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public FormWindowState WindowState { get; set; }
        public int BottomPanelHeight { get; set; }
        public int LeftPanelWidth { get; set; }

        public WindowOptions()
        {
            Height = 768;
            Width = 1024;
            WindowState = FormWindowState.Normal;
            BottomPanelHeight = 168;
            LeftPanelWidth = 224;
        }
    }
}
