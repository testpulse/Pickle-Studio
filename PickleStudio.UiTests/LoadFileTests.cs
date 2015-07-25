using NUnit.Framework;
using PickleStudio.UiTests.Helpers;
using System.IO;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace PickleStudio.UiTests
{
    [TestFixture]
    public class LoadFileTests : BaseUiTests
    {
        [Test]
        public void LoadInvalidFile_OpenDialogDisplaysError()
        {
            using (var pickleStudio = new PickleStudioApplication(true))
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);

                var isSuccessful = pickleStudio.OpenFile("rubbish.feature");
                Assert.That(isSuccessful, Is.False);
            }
        }
   
        [Test]
        public void LoadFile_AppearsInProjectView()
        {
            using (var pickleStudio = new PickleStudioApplication())
            {
                Assert.That(pickleStudio.Window, Is.Not.Null);

                var path = Path.Combine(TestDataLocation, @"Features\Test1.Feature");
                var isSuccessful = pickleStudio.OpenFile(path);
                Assert.That(isSuccessful, Is.True);

                var project = pickleStudio.Window.Get<ListView>(SearchCriteria.ByAutomationId("olvProject"));
                Assert.That(project, Is.Not.Null);
                Assert.That(project.Items.Count, Is.EqualTo(1));

                // should be able to check if it is visible in editor too but although I can find the editor 
                // component, TestStack.White/UIAutomation doesn't seem to recognise it as a text component 
                // and while it seems like it should be possible to extend something to make it work, I can't 
                // work it out and I can't find any examples that show how it's done.
            }
        }
    }
}
