using PickleStudio.Core;
using PickleStudio.Core.Commands;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using PickleStudio.Extensions;
using System;
using System.Windows.Forms;

namespace PickleStudio.Controls
{
    public partial class TestView : UserControl, ITestViewer
    {
        public TestView()
        {
            InitializeComponent();

            tscTest
                .AddToolStrip(CommandGroup.Test, Command.TestRun);

            //Program.State.Project.Opened += OnProjectOpened;
            //Program.State.Project.TestRunFinishedWithException += OnTestRunFinishedWithException;
            //Program.State.Project.TestRunFinishedWithResult += OnTestRunFinishedWithResult;
            //Program.State.Project.TestRunStarted += OnTestRunStarted;
            //Program.State.Project.TestFinished += OnTestFinished;
            //Program.State.Project.TestOutput += OnTestOutput;
            //Program.State.Project.TestStarted += OnTestStarted;
            //Program.State.Project.TestUnhandledException += OnTestUnhandledException;
        }

        //private void OnProjectOpened(object sender, EventArgs<Project> e)
        //{
        //    // TODO initial assembly search for tests
        //}

        //private void OnTestStarted(object sender, EventArgs<TestName> e)
        //{
        //    // TODO add/update test to view
        //}

        //private void OnTestOutput(object sender, EventArgs<TestOutput> e)
        //{
        //}

        //private void OnTestFinished(object sender, EventArgs<TestResult> e)
        //{
        //    // TODO add/update test to view
        //}

        //private void OnTestRunFinishedWithResult(object sender, EventArgs<TestResult> e)
        //{
        //    // TODO update run progress
        //}

        //private void OnTestRunStarted(object sender, EventArgs<string, int> e)
        //{
        //    // TODO update run progress
        //}

        //private void OnTestUnhandledException(object sender, EventArgs<Exception> e)
        //{
        //    // TODO display and update run progress
        //}

        //private void OnTestRunFinishedWithException(object sender, EventArgs<Exception> e)
        //{
        //    // TODO display and update run progress
        //}

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}
