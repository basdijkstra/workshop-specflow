using Examples.DataEntities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Examples.StepDefinitions
{
    [Binding]
    public class SpecFlowAssistSteps
    {
        private Car myCar;

        [Given(@"I have the following car")]
        public void GivenIHaveTheFollowingCar(Table table)
        {
            myCar = table.CreateInstance<Car>();
        }

        private IEnumerable<Car> myCarCollection;

        [Given(@"I have the following car collection")]
        public void GivenIHaveTheFollowingCarCollection(Table table)
        {
            myCarCollection = table.CreateSet<Car>();
        }

        [When(@"I paint my car (.*)")]
        public void WhenIPaintMyCar(string newColor)
        {
            myCar.Color = newColor;
        }

        [When(@"all (.*) cars are rebranded as (.*)")]
        public void WhenAllCarsAreRebrandedAs(String oldMake, String newMake)
        {
            foreach (Car car in myCarCollection)
            {
                if (car.Make.Equals(oldMake))
                {
                    car.Make = newMake;
                }
            }
        }

        [Then(@"I have the following car")]
        public void ThenIHaveTheFollowingCar(Table table)
        {
            table.CompareToInstance<Car>(myCar);
        }

        [Then(@"I have the following car collection")]
        public void ThenIHaveTheFollowingCarCollection(Table table)
        {
            table.CompareToSet<Car>(myCarCollection);
        }
    }
}
