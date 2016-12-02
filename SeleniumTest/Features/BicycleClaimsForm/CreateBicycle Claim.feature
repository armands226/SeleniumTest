Feature: CreateBicycle Claim
	This is simple feature to fill data in bicycle claim

@mytag
Scenario: Open bicycle claim and fill what has happened section
	Given I have opened "BicycleClaimForm" page 
	When I enter the following data into the what has happened section
	| Field					| Value							|
	| IncidentType			| Bicycle has been vandalized	|
	| IncidentDate			| 01.01.2016					|
	| IncidentCountry		| Latvia						|
	| IncidentCity			|								|
	| IncidentPlace			| Riga, Brivibas 12				|
	| IncidentDescription	| They were too many			|
	Then everything is ok