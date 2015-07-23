using NUnit.Framework;
using PickleStudio.Resources;
using PickleStudio.UiTests.Helpers;
using System.IO;

namespace PickleStudio.UiTests
{
    [TestFixture]
    public class LoadFileTests : BaseUiTests
    {
        [Test]
        public void LoadInvalidFile_OpenDialogDisplaysError()
        {
            using (var pickleStudio = new PickleStudioApplication())
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);

                var isSuccessful = pickleStudio.OpenFile("rubbish.feature");
                Assert.That(isSuccessful, Is.False);
            }
        }
   
        [Test]
        public void LoadFile_AppearsInProjectAndEditorViews()
        {
            using (var pickleStudio = new PickleStudioApplication())
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);

                var path = Path.Combine(TestDataLocation, @"Features\Test1.Feature");
                var isSuccessful = pickleStudio.OpenFile(path);
                Assert.That(isSuccessful, Is.True);

                // TODO assert that feature is actually displayed in project and editor views!
            }
        }
    }
}
