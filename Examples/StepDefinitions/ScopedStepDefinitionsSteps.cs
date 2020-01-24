using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class ScopedStepDefinitionsSteps
    {
        [Given(@"I have milk")]
        public void GivenIHaveMilk()
        {
        }

        [Given(@"I have cocoa powder")]
        public void GivenIHaveCocoaPowder()
        {
        }

        [When(@"I put them together")]
        [Scope(Scenario = "Numbers")]
        public void WhenIPutTheNumbersTogether()
        {
        }

        [When(@"I put them together")]
        [Scope(Scenario = "Ingredients")]
        public void WhenIPutTheIngredientsTogether()
        {
        }

        [Then(@"I should end up with chocolate milk")]
        public void ThenIShouldEndUpWithChocolateMilk()
        {
        }
    }
}
