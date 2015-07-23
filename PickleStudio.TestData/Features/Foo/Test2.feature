Feature: Test2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two medium numbers
	Given I have entered 24 into the calculator
	And I have also entered 18 into the calculator
	When I press add
	Then the result should be 42 on the screen
