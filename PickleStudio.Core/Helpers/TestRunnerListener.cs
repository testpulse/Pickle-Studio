using NUnit.Core;
using System;

namespace PickleStudio.Core.Helpers
{
    public class TestRunnerListener : EventListener
    {
        private readonly Action<Exception> _runFinishedWithException;
        private readonly Action<TestResult> _runFinishedWithResult;
        private readonly Action<string, int> _runStarted;
        private readonly Action<TestResult> _suiteFinished;
        private readonly Action<TestName> _suiteStarted;
        private readonly Action<TestResult> _testFinished;
        private readonly Action<TestOutput> _testOutput;
        private readonly Action<TestName> _testStarted;
        private readonly Action<Exception> _unhandledException;

        public TestRunnerListener(
            Action<Exception> runFinishedWithException = null,
            Action<TestResult> runFinishedWithResult = null,
            Action<string, int> runStarted = null,
            Action<TestResult> suiteFinished = null,
            Action<TestName> suiteStarted = null,
            Action<TestResult> testFinished = null,
            Action<TestOutput> testOutput = null,
            Action<TestName> testStarted = null,
            Action<Exception> unhandledException = null)
        {
            _runFinishedWithException = runFinishedWithException;
            _runFinishedWithResult = runFinishedWithResult;
            _runStarted = runStarted;
            _suiteFinished = suiteFinished;
            _suiteStarted = suiteStarted;
            _testFinished = testFinished;
            _testOutput = testOutput;
            _testStarted = testStarted;
            _unhandledException = unhandledException;
        }

        public void RunFinished(Exception exception)
        {
            if (_runFinishedWithException != null) _runFinishedWithException(exception);
        }

        public void RunFinished(TestResult result)
        {
            if (_runFinishedWithException != null) _runFinishedWithResult(result);
        }

        public void RunStarted(string name, int testCount)
        {
            if (_runFinishedWithException != null) _runStarted(name, testCount);
        }

        public void SuiteFinished(TestResult result)
        {
            if (_runFinishedWithException != null) _suiteFinished(result);
        }

        public void SuiteStarted(TestName testName)
        {
            if (_runFinishedWithException != null) _suiteStarted(testName);
        }

        public void TestFinished(TestResult result)
        {
            if (_runFinishedWithException != null) _testFinished(result);
        }

        public void TestOutput(TestOutput testOutput)
        {
            if (_runFinishedWithException != null) _testOutput(testOutput);
        }

        public void TestStarted(TestName testName)
        {
            if (_runFinishedWithException != null) _testStarted(testName);
        }

        public void UnhandledException(Exception exception)
        {
            if (_runFinishedWithException != null) _unhandledException(exception);
        }
    }
}
