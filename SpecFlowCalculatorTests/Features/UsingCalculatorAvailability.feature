Feature: UsingCalculatorAvailability

@MTBF
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press MTBF
	Then the availability result should be 210
	
@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 200 and 210 into the calculator and press Availability
	Then the availability result should be 95.2
	
@MTBF
Scenario Outline: Calculate MTBF with negative inputs
	Given I have a calculator
	When I have entered <value1> and <value2> into the calculator and press MTBF
	Then the <value3> error is thrown
	Examples: 
	  | value1 | value2 | value3         |
	  | -200   | 10     | Negative Input |
	  | -200   | -10    | Negative Input |
   
@Availability
Scenario Outline: Calculating Availability with negative inputs
	Given I have a calculator
	When I have entered <value1> and <value2> into the calculator and press Availability
	Then the <value3> error is thrown
	Examples: 
	  | value1 | value2 | value3         |
	  | -200   | 10     | Negative Input |
	  | -200   | -10    | Negative Input |