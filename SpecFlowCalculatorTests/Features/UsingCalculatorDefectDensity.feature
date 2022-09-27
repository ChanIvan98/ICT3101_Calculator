Feature: UsingCalculatorDefectDensity
	To calculate the total number of Shipped Source Instructions (SSI) by calculating defect density
	
@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator
	When I entered 100 and 50 into the calculator and press DD
	Then the defect density result should be 2.0
	

@DefectDensity
Scenario: Calculate the new total number of Shipped Source Instructions (SSI)
	Given I have a calculator
	When I entered 50 and 20 and 4 and 1 into the calculator and press SSI
	Then the new Shipped Source Instructions (SSI) is 65