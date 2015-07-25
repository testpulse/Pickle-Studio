using PickleStudio.Core.Options;
using System;
using System.Windows.Forms;

namespace PickleStudio.Controls
{
    public partial class FontOptionsControl : UserControl
    {
        public FontOptions FontOptions
        {
            get
            {
                return GetFontOptions();
            }
            set
            {
                SetFontOptions(value);
            }
        }

        public FontOptionsControl()
        {
            InitializeComponent();


        }

        private void txtTextColor_Click(object sender, EventArgs e)
        {
            // TODO show color dialog
        }

        private void txtBackgroundColor_Click(object sender, EventArgs e)
        {
            // TODO show color dialog
        }

        private void SetFontOptions(FontOptions value)
        {
            throw new NotImplementedException();
        }

        private FontOptions GetFontOptions()
        {
            throw new NotImplementedException();
        }
    }
}
