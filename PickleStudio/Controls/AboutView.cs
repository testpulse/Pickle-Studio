using BrightIdeasSoftware;
using PickleStudio.Core.Helpers;
using PickleStudio.Interfaces;
using PickleStudio.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PickleStudio.Controls
{
    public partial class AboutView : UserControl, IDialogControl
    {
        public AboutView()
        {
            InitializeComponent();

            lblAbout.Text = Resources.HelpAboutDialogText;
            btnClose.Text = Resources.CloseButtonText;

            olvThirdPartyComponents.HyperlinkClicked += OnHyperlinkClick;
            olvThirdPartyComponents.CellToolTipGetter = UrlGetter;

            var components = new List<ThirdPartyComponent>
            {
                new ThirdPartyComponent { Name = "AvalonEdit", Url = "http://avalonedit.net/", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "Json.Net", Url = "http://www.newtonsoft.com/json", LicenseName = "MIT", LicenseUrl = "https://raw.githubusercontent.com/JamesNK/Newtonsoft.Json/master/LICENSE.md" },
                new ThirdPartyComponent { Name = "ObjectListView", Url = "http://objectlistview.sourceforge.net/", LicenseName = "GNU GPL", LicenseUrl = "http://www.gnu.org/licenses/gpl.html" },
                new ThirdPartyComponent { Name = "Fugue Icons", Url = "http://p.yusukekamiyamane.com/", LicenseName = "Creative Commons Attribution 3.0", LicenseUrl = "http://creativecommons.org/licenses/by/3.0/" },
                new ThirdPartyComponent { Name = "Fody", Url = "https://github.com/Fody/Fody", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "Costura", Url = "https://github.com/Fody/Costura/", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "NUnit", Url = "http://www.nunit.org/", LicenseName = "NUnit", LicenseUrl = "http://www.nunit.org/nuget/license.html" },
            };

            olvThirdPartyComponents.SetObjects(components.OrderBy(c => c.Name));
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
