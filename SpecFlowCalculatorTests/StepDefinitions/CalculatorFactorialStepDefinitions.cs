using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorFactorialStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    private Exception _exception;

    public CalculatorFactorialStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }

    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
    {
        try
        {
            _result = _calculator.Factorial(p0);
        }
        catch (Exception e)
        {
            _exception = e;
        }
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }


    [Then(@"the (.*) error is thrown")]
    public void ThenTheErrorIsThrown(string exception)
    {
        if (_exception != null)
        {
            Assert.That(_exception.Message, Is.EqualTo(exception));
        }
    }
}