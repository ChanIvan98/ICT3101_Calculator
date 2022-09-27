Feature: UsingCalculatorBasicReliability
	
@BasicReliability
Scenario: Calculating Current Failure Intensity
	Given I have a calculator
	When the initial failure intensity was 10 failures per CPU hours, average number of failures is 50 and the number of failures over infinite time is 100
	Then the current failure intensity calculated should be 5
	
@BasicReliability
Scenario: Calculating average number of expected failures
	Given I have a calculator
	When the initial failure intensity was 10 failures per CPU hours, average number of failures is 50 and the number of failures over infinite time is 100 after 10 CPU hours
	Then the current failure intensity calculated should be 63
	
@BasicReliability
Scenario Outline: Calculating Current Failure Intensity with Invalid Inputs
	Given I have a calculator
	When the initial failure intensity was <value1> failures per CPU hours, average number of failures is <value2> and the number of failures over infinite time is <value3>
	Then the <value4> error is thrown
	Examples: 
	| value1 | value2 | value3 | value4                 |
	| -10    | 50     | 100    | Negative Input or Zero |
	| 10     | -50    | -100   | Negative Input or Zero |