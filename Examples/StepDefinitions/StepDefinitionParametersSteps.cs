using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class StepDefinitionParametersSteps
    {
        [Given(@"I have a bucket of (.*) paint")]
        public void GivenIHaveABucketOfPaint(string Color)
        {
        }

        [When(@"I mix them together")]
        public void WhenIMixThemTogether()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I have a bucket of pink paint")]
        public void ThenIHaveABucketOfPinkPaint()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
