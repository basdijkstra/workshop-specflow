using System;
using TechTalk.SpecFlow;

namespace ExerciseAnswers.StepDefinitions
{
    [Binding]
    public class GeneratingStepDefinitionsSteps
    {
        [Given(@"I have scenario with undefined steps")]
        public void GivenIHaveScenarioWithUndefinedSteps()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I generate step definitions using regular expressions")]
        public void WhenIGenerateStepDefinitionsUsingRegularExpressions()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"these steps should turn from purple to white")]
        public void ThenTheseStepsShouldTurnFromPurpleToWhite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
