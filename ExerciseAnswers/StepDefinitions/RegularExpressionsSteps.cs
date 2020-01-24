using System;
using TechTalk.SpecFlow;

namespace ExerciseAnswers.StepDefinitions
{
    [Binding]
    public class RegularExpressionsSteps
    {
        [Given(@"I have an empty basket")]
        public void GivenIHaveAnEmptyBasket()
        {
        }

        [Given(@"I am a collector of flags")]
        public void GivenIAmACollectorOfFlags()
        {
        }

        [Given(@"I have an empty fruit bowl")]
        public void GivenIHaveAnEmptyFruitBowl()
        {
        }

        [When(@"I put (\d+) apples in my basket")]
        public void WhenIPutApplesInMyBasket(int NumberOfApples)
        {
        }

        [When(@"I create a collection of flags from the Benelux countries")]
        public void WhenICreateACollectionOfFlagsFromTheBeneluxCountries()
        {
        }

        [When(@"I throw in an? (.*)")]
        public void WhenThrowInA(string TypeOfFruit)
        {
        }

        [Then(@"I have (\d+) apples in my basket")]
        public void ThenIHaveApplesInMyBasket(int NumberOfApples)
        {
        }

        [Then(@"I should add a flag from (The Netherlands|Belgium|Luxembourg)")]
        public void ThenIShouldAddAFlagFrom(string country)
        {
        }

        [Then(@"I have a filled fruit bowl")]
        public void ThenIHaveAFilledFruitBowl()
        {
        }
    }
}
