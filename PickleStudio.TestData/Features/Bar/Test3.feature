Feature: Test3
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two little numbers
	Given I have entered 6 into the calculator
	And I have also entered 3 into the calculator
	When I press add
	Then the result should be 9 on the screen
