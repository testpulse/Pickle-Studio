using System.Windows.Forms;

namespace PickleStudio.Core
{
    public class WindowSettings
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public FormWindowState WindowState { get; set; }
        public int BottomPanelHeight { get; set; }
        public int LeftPanelWidth { get; set; }

        public WindowSettings()
        {
            Height = 768;
            Width = 1024;
            WindowState = FormWindowState.Normal;
            BottomPanelHeight = 168;
            LeftPanelWidth = 224;
        }
    }
}
