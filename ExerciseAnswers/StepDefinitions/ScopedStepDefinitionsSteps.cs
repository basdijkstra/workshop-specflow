using System;
using TechTalk.SpecFlow;

namespace ExerciseAnswers.StepDefinitions
{
    [Binding]
    public class ScopedStepDefinitionsSteps
    {
        [Given(@"I am staying in a hotel")]
        public void GivenIAmStayingInAHotel()
        {
        }

        [Given(@"I want a new set of towels")]
        public void GivenIWantANewSetOfTowels()
        {
        }

        [Given(@"I work in an office")]
        [Scope(Feature = "ScopedStepDefinitions")]
        public void GivenIWorkInAnOffice()
        {
        }

        [Given(@"I want local admin rights on my workstation")]
        public void GivenIWantLocalAdminRightsOnMyWorkstation()
        {
        }

        [Given(@"I want a new workstation")]
        [Scope(Scenario = "Office helpdesk request 2")]
        public void GivenIWantANewWorkstation()
        {
        }

        [Given(@"I have a mobile phone plan")]
        public void GivenIHaveAMobilePhonePlan()
        {
        }

        [Given(@"I have forgotten my PUK code")]
        public void GivenIHaveForgottenMyPUKCode()
        {
        }

        [When(@"I send a request to the service desk")]
        [Scope(Tag = "cleaningservice")]
        public void WhenISendARequestToTheCleaningServiceDesk()
        {
        }

        [When(@"I send a request to the service desk")]
        [Scope(Tag = "officehelpdesk")]
        public void WhenISendARequestToTheOfficeServiceDesk()
        {
        }

        [When(@"I send a request to the service desk")]
        [Scope(Tag = "telephonehelpdesk")]
        public void WhenISendARequestToTheTelephoneServiceDesk()
        {
        }

        [Then(@"I should have new towels by the end of the day")]
        public void ThenIShouldHaveNewTowelsByTheEndOfTheDay()
        {
        }

        [Then(@"I should have local admin rights after half an hour")]
        public void ThenIShouldHaveLocalAdminRightsAfterHalfAnHour()
        {
        }

        [Then(@"I should have a new workstation after a day")]
        public void ThenIShouldHaveANewWorkstationAfterADay()
        {
        }

        [Then(@"I should see no result at all within a week")]
        public void ThenIShouldSeeNoResultAtAllWithinAWeek()
        {
        }
    }
}
