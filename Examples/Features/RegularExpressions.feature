Feature: RegularExpressions
	In order to 

Scenario: Match only integers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	And I have entered banana into the calculator

Scenario: Match only specific values
	Given Maserati is an Italian car brand
	And Lamborghini is an Italian car brand
	And Volkswagen is an Italian car brand

Scenario: Match singular and plural
	Given I have the following devices
		| DeviceName        |
		| Samsung Galaxy 10 |
		| Huawei P20        |
	And I have the following device
		| DeviceName     |
		| Apple iPhone X |

