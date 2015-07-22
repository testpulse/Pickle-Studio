using NUnit.Framework;
using PickleStudio.UiTests.Helpers;
using System.IO;
using TestStack.White.UIItems.WindowItems;

namespace PickleStudio.UiTests
{
    [TestFixture]
    public class MainFormTests : BaseUiTests
    {
        [Test]
        public void ApplicationLaunch_DisplayMainForm()
        {
            using (var pickleStudio = new PickleStudioApplication())
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);
                Assert.That(pickleStudio.Window.DisplayState == DisplayState.Restored, Is.True);
            }
        }

        [Test]
        public void ApplicationExit_CreateSettingsFile()
        {
            using (var pickleStudio = new PickleStudioApplication(true))
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);
            }
            Assert.That(File.Exists(PickleStudioApplication.SettingsLocation), Is.True);
        }
    }
}
