using PickleStudio.Core;
using PickleStudio.Core.Options;
using PickleStudio.Resources;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace PickleStudio.UiTests.Helpers
{
    public class PickleStudioApplication : IDisposable
    {
        private static readonly Assembly _assembly = typeof(Program).Assembly;

        public static string ExeLocation { get { return _assembly.Location; } }
        public static string SettingsLocation { get { return Path.Combine(Path.GetDirectoryName(ExeLocation), ApplicationOptions.FileName); } }

        public Application Application { get; private set; }
        public Window Window { get; private set; }

        private readonly bool _killOnDispose;

        public PickleStudioApplication(bool killOnDispose = false)
        {
            _killOnDispose = killOnDispose;

            var windowTitle = (AssemblyProductAttribute)_assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), true).First();
            Application = Application.Launch(_assembly.Location);
            Window = Application.GetWindow(windowTitle.Product, InitializeOption.NoCache);
        }

        public bool ClickToolBarButton(string name)
        {
            var panel = Window.Get<Panel>("tscMain");
            var toolStrips = panel.GetMultiple(SearchCriteria.ByControlType(typeof(ToolStrip), WindowsFramework.WinForms));
            foreach (var toolStrip in toolStrips)
            {
                // tool strip items aren't real controls so we have to do this rubbish...
                var toolStripItems = toolStrip.AutomationElement.FindAll(TreeScope.Descendants, Condition.TrueCondition);
                foreach (AutomationElement toolStripItem in toolStripItems)
                {
                    if (toolStripItem.Current.ControlType == ControlType.Button && toolStripItem.Current.Name == name)
                    {
                        var invokePattern = toolStripItem.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                        invokePattern.Invoke();
                        return true;
                    }
                }
            }

            return false;
        }

        public bool OpenFile(string fileName)
        {
            var isClicked = ClickToolBarButton(Strings.FileOpenText);
            if (!isClicked) return false;

            Window openDialog = Application.GetWindows().Where(n => n.Name == "Open").First();

            TextBox textField = openDialog.Get<TextBox>(SearchCriteria.ByControlType(ControlType.Edit).AndByText("File name:"));
            textField.Text = fileName;

            Button openButton = openDialog.Get<Button>(SearchCriteria.ByControlType(ControlType.Button).AndByText("Open"));
            openButton.Click();
            return openDialog.IsClosed;
        }

        public void Dispose()
        {
            if (Application == null) return;
            if (_killOnDispose) 
                Application.Kill(); 
            else 
                Application.Close();
        }
    }
}
