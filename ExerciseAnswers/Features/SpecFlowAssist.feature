﻿Feature: SpecFlowAssist
	In order to work with POCOs more effectively
	As a SpecFlow student
	I want to learn how to wield the powers of SpecFlow.Assist

Scenario: Create, modify and compare album details
	Given the following album exists
		| Artist    | Title      | ReleaseYear | LengthInMinutes | RecordLabel        |
		| Faithless | Sunday 8PM | 1998        | 58              | Cheeky Records/BMG |
	When the album is rereleased
	Then the new album details should be
		| Artist    | Title      | ReleaseYear | LengthInMinutes | RecordLabel        |
		| Faithless | Sunday 8PM | 2019        | 58              | Cheeky Records/BMG |
