using NUnit.Framework;
using System;
using System.IO;

namespace PickleStudio.UiTests.Helpers
{
    public class BaseUiTests
    {
        private static readonly Lazy<string> _testDataLocation = new Lazy<string>(() => Path.GetDirectoryName(typeof(PickleStudioApplication).Assembly.Location) + @"\..\..\..\PickleStudio.TestData\");

        public string TestDataLocation { get { return _testDataLocation.Value; } }

        [SetUp]
        public virtual void SetUp()
        {
            File.Delete(PickleStudioApplication.SettingsLocation);
        }
    }
}
