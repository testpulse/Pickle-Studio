using BrightIdeasSoftware;
using PickleStudio.Core.Helpers;
using PickleStudio.Interfaces;
using PickleStudio.Resources;
using System;
using System.Windows.Forms;

namespace PickleStudio.Controls
{
    public partial class AboutView : UserControl, IDialogControl
    {
        public AboutView()
        {
            InitializeComponent();

            lblAbout.Text = Strings.HelpAboutDialogText;
            btnClose.Text = Strings.CloseButtonText;

            olvThirdPartyComponents.HyperlinkClicked += OnHyperlinkClick;
            olvThirdPartyComponents.CellToolTipGetter = UrlGetter;

            olvThirdPartyComponents.SetObjects(ThirdPartyComponent.List);
        }

        private string UrlGetter(OLVColumn column, object modelObject)
        {
            var model = (ThirdPartyComponent)modelObject;
            return (column == colName) ? model.Url : model.LicenseUrl;
        }

        private void OnHyperlinkClick(object sender, HyperlinkClickedEventArgs e)
        {
            e.Url = UrlGetter(e.Column, e.Model);
        }

        public string Title
        {
            get 
            { 
                var version = Version.Parse(Application.ProductVersion);
                return string.Format("About {0} v{1}.{2}.{3}", Application.ProductName, version.Major, version.Minor, version.Build); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Close();
        }
    }
}
