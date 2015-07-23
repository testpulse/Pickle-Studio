using NUnit.Framework;
using TechTalk.SpecFlow;

namespace PickleStudio.TestData.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            var calculator = new Calculator();
            calculator.Numbers.Add(number);
            ScenarioContext.Current.Set(calculator);
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            ScenarioContext.Current.Get<Calculator>().Numbers.Add(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var result = ScenarioContext.Current.Get<Calculator>().Add();
            ScenarioContext.Current.Set(result);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, ScenarioContext.Current.Get<int>());
        }
    }
}
