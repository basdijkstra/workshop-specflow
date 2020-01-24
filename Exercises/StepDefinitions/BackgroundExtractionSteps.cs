using Exercises.DataEntities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Exercises.StepDefinitions
{
    [Binding]
    public class BackgroundExtractionSteps
    {
        private Calculator calculator;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculator = new Calculator();
        }

        [Given(@"the calculator shows (.*) in its display")]
        public void GivenTheCalculatorShowsInItsDisplay(int NumberToDisplay)
        {
            calculator.SetTotalTo(NumberToDisplay);
        }

        [When(@"I add (.*)")]
        public void WhenIAdd(int NumberToAdd)
        {
            calculator.Add(NumberToAdd);
        }

        [When(@"I multiply with (.*)")]
        public void WhenIMultiplyWith(int NumberToMultiplyWith)
        {
            calculator.Multiply(NumberToMultiplyWith);
        }

        [When(@"I subtract (.*)")]
        public void WhenISubtract(int NumberToSubtract)
        {
            calculator.Subtract(NumberToSubtract);
        }

        [Then(@"the calculator shows (.*) in its display")]
        public void ThenTheCalculatorShowsInItsDisplay(int ExpectedNumberInDisplay)
        {
            Assert.AreEqual(ExpectedNumberInDisplay, calculator.CurrentTotal);
        }
    }
}
