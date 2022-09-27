using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorAvailabilityStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    private Exception _exception;

    public CalculatorAvailabilityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(int p0, int p1)
    {
        try
        {
            _result = _calculator.calculateMTBF(p0, p1);
        }
        catch (Exception e)
        {
            _exception = e;
        }
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
    {
        try
        {
            _result = _calculator.calculateAvailability(p0, p1);
        }
        catch(Exception e)
        {
            _exception = e;
        }
    }
}