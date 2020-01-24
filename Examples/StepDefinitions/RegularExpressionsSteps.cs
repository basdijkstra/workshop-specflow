using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class RegularExpressionsSteps
    {
        [Given(@"(Maserati|Lamborghini) is an Italian car brand")]
        public void GivenIsAnItalianCarBrand(string CarBrand)
        {
        }

        [Given(@"I have the following devices?")]
        public void GivenIHaveTheFollowingDevices(Table table)
        {
        }
    }
}
