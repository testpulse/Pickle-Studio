using PickleStudio.Core.Options;
using PickleStudio.Extensions;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

namespace PickleStudio.Views.Controls
{
    public partial class FontOptionsControl : UserControl
    {
        private static List<FontWeight> _fontWeights = new List<FontWeight>
        {
            FontWeights.Black,
            FontWeights.Bold,
            FontWeights.DemiBold,
            FontWeights.ExtraBlack,
            FontWeights.ExtraBold,
            FontWeights.ExtraLight,
            FontWeights.Heavy,
            FontWeights.Light,
            FontWeights.Medium,
            FontWeights.Normal,
            FontWeights.Regular,
            FontWeights.SemiBold,
            FontWeights.Thin,
            FontWeights.UltraBlack,
            FontWeights.UltraBold,
            FontWeights.UltraLight
        };

        private static List<FontStyle> _fontStyles = new List<FontStyle>
        {
            FontStyles.Italic,
            FontStyles.Normal,
            FontStyles.Oblique
        };

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

            cbxFontWeight.DataSource = _fontWeights;
            cbxFontStyle.DataSource = _fontStyles;
        }

        private void lblBackgroundColorSelector_Click(object sender, EventArgs e)
        {
            ChooseColor(lblBackgroundColorSelector);
        }

        private void lblTextColorSelector_Click(object sender, EventArgs e)
        {
            ChooseColor(lblTextColorSelector);
        }

        private void ChooseColor(Label label)
        {
            var dialog = new ColorDialog();
            dialog.Color = label.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label.BackColor = dialog.Color;
            }
        }

        private void SetFontOptions(FontOptions value)
        {
            lblBackgroundColorSelector.BackColor = value.BackgroundColor.ToWinFormsColor();
            lblTextColorSelector.BackColor = value.TextColor.ToWinFormsColor();
            cbxFontWeight.SelectedItem = value.Weight;
            cbxFontStyle.SelectedItem = value.Style;
            chkUnderline.Checked = value.Underline;
        }

        private FontOptions GetFontOptions()
        {
            var options = new FontOptions
            {
                BackgroundColor = lblBackgroundColorSelector.BackColor.ToWpfColor(),
                TextColor = lblTextColorSelector.BackColor.ToWpfColor(),
                Weight = (FontWeight)cbxFontWeight.SelectedItem,
                Style = (FontStyle)cbxFontStyle.SelectedItem,
                Underline = chkUnderline.Checked
            };
            return options;
        }
    }
}
