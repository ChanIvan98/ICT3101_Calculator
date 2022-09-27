Feature: UsingCalculatorFactorial
	Simple calculator for performing Factorial

@Factorial
Scenario Outline: Factorial with positive input
	Given I have a calculator
	When I have entered <value1> into the calculator and press factorial
	Then the factorial result should be <output>
	Examples: 
	| value1 | output |
	| 5      | 120    |
	| 3      | 6      |
	
@Factorial
Scenario: Factorial with zero
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial
	Then the factorial result should be 1
	
@Factorial
Scenario: Factorial with negative input
	Given I have a calculator
	When I have entered -5 into the calculator and press factorial
	Then the Negative Input error is thrown