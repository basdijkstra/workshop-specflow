Feature: SpecFlowAssist
	In order to 

Scenario: SpecFlow.Assist example
	Given I have the following car
		| Make       | Model  | Color | Year |
		| Alfa Romeo | Giulia | red   | 2018 |
	When I paint my car blue
	Then I have the following car
		| Make       | Model  | Color | Year |
		| Alfa Romeo | Giulia | blue  | 2018 |

Scenario: SpecFlow.Assist example with multiple table rows
	Given I have the following car collection
		| Make    | Model      | Color | Year |
		| Daewoo  | Matiz      | Grey  | 1995 |
		| Daewoo  | Lacetti    | Black | 1997 |
		| Ferrari | Testarossa | Red   | 1988 |
	When all Daewoo cars are rebranded as Chevrolet
	Then I have the following car collection
		| Make      | Model      | Color | Year |
		| Ferrari   | Testarossa | Red   | 1988 |
		| Chevrolet | Matiz      | Grey  | 1995 |
		| Chevrolet | Lacetti    | Black | 1997 |
