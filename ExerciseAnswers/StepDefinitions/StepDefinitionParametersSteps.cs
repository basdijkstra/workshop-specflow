using System;
using TechTalk.SpecFlow;

namespace ExerciseAnswers.StepDefinitions
{
    [Binding]
    public class StepDefinitionParametersSteps
    {
        [Given(@"I have a (.*) drink")]
        public void GivenIHaveADrink(string colorOfDrink)
        {
        }

        [When(@"I mix them together")]
        public void WhenIMixThemTogether()
        {
        }

        [Then(@"I have a (.*) drink")]
        public void ThenIHaveADrink(string resultingColorOfDrink)
        {
        }
    }
}
