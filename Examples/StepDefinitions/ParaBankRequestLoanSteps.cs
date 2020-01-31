using System;
using TechTalk.SpecFlow;

namespace Examples.StepDefinitions
{
    [Binding]
    public class ParaBankRequestLoanSteps
    {
        [Given(@"(.*) has a (checking|savings) bank account with a balance of (\d+) dollars")]
        public void GivenHasACheckingBankAccountWithABalanceOfDollars(string firstName, string accountType, int accountBalance)
        {
        }
               
        [When(@"s?he applies for a loan of (\d+) dollars")]
        public void WhenSHeAppliesForALoanOfDollars(int loanAmount)
        {
        }
        
        [When(@"the loan processor service is offline")]
        public void WhenTheLoanProcessorServiceIsOffline()
        {
        }
        
        [Then(@"the loan request is (approved|denied)")]
        public void ThenTheLoanRequestIsDenied(string loanApplicationResult)
        {
        }
        
        [Then(@"(.*) sees an error message stating that his loan request could not be processed at this time")]
        public void ThenSeesAnErrorMessageStatingThatHisLoanRequestCouldNotBeProcessedAtThisTime(string firstName)
        {
        }
    }
}
