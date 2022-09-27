using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorFailureIntensityStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    
    public CalculatorFailureIntensityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I enter (.*) and (.*) and (.*) into the calculator and press FI")]
    public void WhenIEnterForTheFailureIntensityDecayForTheInitialFailureIntensityAndForTheAverageNumberOfFailures(double p0, int p1, int p2)
    {
        _result = _calculator.CalculateFailureIntensityLogarithmic(p0, p1, p2);
    }

    [Then(@"the failure intensity result is (.*)")]
    public void ThenTheFailureIntensityResultIs(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I enter (.*) and (.*) and (.*) into the calculator and press EF")]
    public void WhenIEnterForTheFailureIntensityDecayForTheInitialFailureIntensityForTheAverageNumberOfFailuresAndForTheCpuHours(double p0, int p1, int p2)
    {
        _result = _calculator.CalculateNumberOfExpectedFailure(p0, p1, p2);
    }

    [Then(@"the number of expected failure is (.*)")]
    public void ThenTheNumberOfExpectedFailureIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}