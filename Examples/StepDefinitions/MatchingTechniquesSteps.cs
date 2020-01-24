using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class MatchingTechniquesSteps
    {
        [Given(@"I can match a step using regular expressions")]
        public void GivenICanMatchAStepUsingRegularExpressions()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add a new step to my scenario")]
        public void WhenIAddANewStepToMyScenario()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
