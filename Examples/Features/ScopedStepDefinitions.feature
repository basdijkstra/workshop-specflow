Feature: ScopedStepDefinitions
	In order to 

Scenario: Numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I put them together
	Then the result should be 120 on the screen

Scenario: Ingredients
	Given I have milk
	And I have cocoa powder
	When I put them together
	Then I should end up with chocolate milk