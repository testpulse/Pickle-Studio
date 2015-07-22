using NUnit.Framework;
using System.IO;

namespace PickleStudio.UiTests.Helpers
{
    public class BaseUiTests
    {
        [SetUp]
        public virtual void SetUp()
        {
            File.Delete(PickleStudioApplication.SettingsLocation);
        }
    }
}
