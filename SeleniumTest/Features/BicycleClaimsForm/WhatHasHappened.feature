Feature: BicycleClaimsForm WhatHasHappened
	In order to verify that the 1st section works properly
	I want to change values for all section 1 elements
	And check if the fields are filled properly

Scenario Outline: click radio button and verify
	Click radio button and verify that the correct radio button is selected and that the rest are unselected
	Given I have opened "BicycleClaimForm" page 
	When I click "<RadioButton1>" radio button
	Then "<RadioButton1>" radio button is selected
	And "<RadioButton2>" radio button is unselected
	And "<RadioButton3>" radio button is unselected
	And "<RadioButton4>" radio button is unselected
	Examples: 
	| Version      | RadioButton1                                                 | RadioButton2                            | RadioButton3                | RadioButton4                                                 |
	| 1st checkbox | Bicycle or parts of it have been stolen                      | Bicycle has been vandalized             | Bicycle has got broken      | Bicycle has been damaged in a collision with a motor vehicle |
	| 2nd checkbox | Bicycle has been vandalized                                  | Bicycle or parts of it have been stolen | Bicycle has got broken      | Bicycle has been damaged in a collision with a motor vehicle |
	| 3rd checkbox | Bicycle has got broken                                       | Bicycle or parts of it have been stolen | Bicycle has been vandalized | Bicycle has been damaged in a collision with a motor vehicle |
	| 4th checkbox | Bicycle has been damaged in a collision with a motor vehicle | Bicycle or parts of it have been stolen | Bicycle has been vandalized | Bicycle has got broken                                       |
