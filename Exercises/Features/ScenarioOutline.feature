Feature: ScenarioOutline
	In order to avoid duplicate scenario and unreadable features
	As a SpecFlow student
	I want to learn how to refactor common scenarios into a scenario outline

Background: Create a Calculator and its initial state
	Given I have a calculator
	And the calculator shows 5 in its display

Scenario: Add 5 results in 10
	When I add 5
	Then the calculator shows 10 in its display

Scenario: Add 1 results in 6
	When I add 1
	Then the calculator shows 6 in its display

Scenario: Add 14 results in 19
	When I add 14
	Then the calculator shows 19 in its display

Scenario: Add 12340 results in 12345
	When I add 12340
	Then the calculator shows 12345 in its display
