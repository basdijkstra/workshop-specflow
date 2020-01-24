Feature: GeneratingStepDefinitions
	In order to learn how to create step definitions
	As a SpecFlow student
	I want to learn how to generate step definitions from feature files

Scenario: Generate step definitions from Visual Studio
	Given I have scenario with undefined steps
	When I generate step definitions using regular expressions
	Then these steps should turn from purple to white
