Feature: ScopedStepDefinitions
	In order to create the best readable features and scenarios
	As a SpecFlow student
	I want to learn how to apply step definition scoping

# TO DO: Make sure that the step definition for 'Given I work in an office' ties to this feature only
# TO DO: Make sure that the step definition for 'Given I want a new workstation' ties to the scenario it's used in only
# TO DO: Implement three different variants of 'When I send a request to the service desk'
#        One for the cleaning service desk, one for the office helpdesk, one for the telephone helpdesk
	
@cleaningservice
Scenario: Cleaning service
	Given I am staying in a hotel
	And I want a new set of towels
	When I send a request to the service desk
	Then I should have new towels by the end of the day

@officehelpdesk
Scenario: Office helpdesk request 1
	Given I work in an office
	And I want local admin rights on my workstation
	When I send a request to the service desk
	Then I should have local admin rights after half an hour

@officehelpdesk
Scenario: Office helpdesk request 2
	Given I work in an office
	And I want a new workstation
	When I send a request to the service desk
	Then I should have a new workstation after a day

@telephonehelpdesk
Scenario: Telephone provider helpdesk
	Given I have a mobile phone plan
	And I have forgotten my PUK code
	When I send a request to the service desk
	Then I should see no result at all within a week