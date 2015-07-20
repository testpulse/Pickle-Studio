using NUnit.Core;
using System.IO;

namespace PickleStudio.Core.Helpers
{
    public class TestRunner
    {
        private readonly string _path;
        private readonly EventListener _eventListener;

        public TestRunner(string path, EventListener eventListener)
        {
            _path = path;
            _eventListener = eventListener;
        }

        public void Run()
        {
            if (!File.Exists(_path)) return;
            var testPackage = new TestPackage(_path);
            var remoteTestRunner = new RemoteTestRunner();
            if (!remoteTestRunner.Load(testPackage)) return;

            var testResult = remoteTestRunner.Run(_eventListener, TestFilter.Empty, false, LoggingThreshold.Error);
        }
    }
}
