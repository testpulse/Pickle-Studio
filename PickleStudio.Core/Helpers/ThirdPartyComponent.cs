using System.Collections.Generic;
using System.Linq;

namespace PickleStudio.Core.Helpers
{
    public class ThirdPartyComponent
    {
        private static readonly IEnumerable<ThirdPartyComponent> _list = new List<ThirdPartyComponent>
            {
                new ThirdPartyComponent { Name = "AvalonEdit", Url = "http://avalonedit.net/", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "Json.Net", Url = "http://www.newtonsoft.com/json", LicenseName = "MIT", LicenseUrl = "https://raw.githubusercontent.com/JamesNK/Newtonsoft.Json/master/LICENSE.md" },
                new ThirdPartyComponent { Name = "ObjectListView", Url = "http://objectlistview.sourceforge.net/", LicenseName = "GNU GPL", LicenseUrl = "http://www.gnu.org/licenses/gpl.html" },
                new ThirdPartyComponent { Name = "Fugue Icons", Url = "http://p.yusukekamiyamane.com/", LicenseName = "Creative Commons Attribution 3.0", LicenseUrl = "http://creativecommons.org/licenses/by/3.0/" },
                new ThirdPartyComponent { Name = "Fody", Url = "https://github.com/Fody/Fody", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "Costura", Url = "https://github.com/Fody/Costura/", LicenseName = "MIT", LicenseUrl = "http://opensource.org/licenses/MIT" },
                new ThirdPartyComponent { Name = "NUnit", Url = "http://www.nunit.org/", LicenseName = "NUnit", LicenseUrl = "http://www.nunit.org/nuget/license.html" },
                new ThirdPartyComponent { Name = "TestStack.White", Url = "https://github.com/TestStack/White", LicenseName = "MIT or Apache 2", LicenseUrl = "https://github.com/TestStack/White/blob/master/LICENSE.txt" },
            }.OrderBy(c => c.Name);

        public static IEnumerable<ThirdPartyComponent> List { get { return _list; } }

        public string Name { get; set; }
        public string Url { get; set; }
        public string LicenseName { get; set; }
        public string LicenseUrl { get; set; }
    }
}
