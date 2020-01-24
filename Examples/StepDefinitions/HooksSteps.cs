using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class HooksSteps
    {        
        [BeforeFeature]
        public static void BeforeFeatureHook()
        {
            Console.WriteLine("Starting feature...");
        }

        [BeforeScenario]
        public static void BeforeScenarioHook()
        {
            Console.WriteLine("Starting scenario...");
        }

        [Given(@"I have a scenario")]
        public void GivenIHaveAScenario()
        {
        }

        [Given(@"I have another scenario")]
        public void GivenIHaveAnotherScenario()
        {
        }

        [When(@"I define hooks")]
        public void WhenIDefineHooks()
        {
        }

        [Then(@"these hooks are also executed")]
        public void ThenTheseHooksAreAlsoExecuted()
        {
        }

        [Then(@"these hooks are also executed for the second scenario")]
        public void ThenTheseHooksAreAlsoExecutedForTheSecondScenario()
        {
        }
    }
}
