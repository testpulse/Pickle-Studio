using PickleStudio.Core;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

namespace PickleStudio.UiTests.Helpers
{
    public class PickleStudioApplication : IDisposable
    {
        private static readonly Assembly _assembly = typeof(Program).Assembly;

        public static string ExeLocation { get { return _assembly.Location; } }
        public static string SettingsLocation { get { return Path.Combine(Path.GetDirectoryName(ExeLocation), Settings.FileName); } }

        public Application Application { get; private set; }
        public Window Window { get; private set; }

        private readonly bool _keepSettingsOnDispose;

        public PickleStudioApplication(bool keepSettingsOnDispose = false)
        {
            _keepSettingsOnDispose = keepSettingsOnDispose;

            var windowTitle = (AssemblyProductAttribute)_assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), true).First();
            Application = Application.Launch(_assembly.Location);
            Window = Application.GetWindow(windowTitle.Product, InitializeOption.NoCache);
        }

        public void Dispose()
        {
            if (Application == null) return;
            Application.Close();
            if (_keepSettingsOnDispose) return;
            File.Delete(Settings.FileName);
        }
    }
}
