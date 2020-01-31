Feature: ParaBankRequestLoan
	In order to temporarily increase my cash flow
	As a ParaBank client
	I want to apply for a loan

Scenario Outline: Loan request denied - insufficient funds in checking account
	Given Bart has a checking bank account with a balance of <balance> dollars
	When he applies for a loan of <loanAmount> dollars
	Then the loan request is denied
	Examples:
	| balance | loanAmount |
	| 1000    | 751        |
	| 1000    | 999        |
	| 1000    | 1001       |

Scenario Outline: Loan request approved - sufficient funds in checking account
	Given Jenny has a checking bank account with a balance of <balance> dollars
	When she applies for a loan of <loanAmount> dollars
	Then the loan request is approved
	Examples:
	| balance | loanAmount |
	| 1000    | 750        |
	| 1000    | 1          |

Scenario: Loan request result approved - additional funds in savings account
	Given Adam has a checking bank account with a balance of 1000 dollars
	And Adam has a savings bank account with a balance of 500 dollars
	When he applies for a loan of 600 dollars
	Then the loan request is approved

Scenario: Loan request result denied - additional funds in savings account
	Given Karen has a checking bank account with a balance of 1000 dollars
	And Karen has a savings bank account with a balance of 500 dollars
	When he applies for a loan of 900 dollars
	Then the loan request is denied

Scenario: Loan request result cannot be processed because loan processor is offline
	Given Johnny has a checking bank account with a balance of 1000 dollars
	When he applies for a loan of 250 dollars
	But the loan processor service is offline
	Then the loan request is denied
	And Johnny sees an error message stating that his loan request could not be processed at this time