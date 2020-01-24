using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class CalculatorExampleSteps
    {
        [Given(@"I have entered (\d+) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
        }
    }
}
