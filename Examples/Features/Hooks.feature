Feature: Hooks
	In order to run additional automation logic
	As a SpecFlow student
	I want to learn how to use hooks

Scenario: Add hooks and run the scenario
	Given I have a scenario
	When I define hooks
	Then these hooks are also executed

Scenario: Add hooks and run this scenario too
	Given I have another scenario
	When I define hooks
	Then these hooks are also executed for the second scenario