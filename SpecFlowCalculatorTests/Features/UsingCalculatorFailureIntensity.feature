Feature: UsingCalculatorFailureIntensity
	Calculator to calculate the failure intensity and the number of expected failures using the Musa Logarithmic Model

@FailureIntensity
Scenario: Calculate failure intensity using the Musa Logarithmic Model
	Given I have a calculator
	When I enter 0.02 and 10 and 50 into the calculator and press FI
	Then the failure intensity result is 4
	
Scenario: Calculate the number of expected failures using the Musa Logarithmic Model
	Given I have a calculator
	When I enter 0.02 and 10 and 10 into the calculator and press EF
	Then the number of expected failure is 55
