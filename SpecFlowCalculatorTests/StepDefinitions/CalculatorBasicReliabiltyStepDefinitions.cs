using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorBasicReliabiltyStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    private Exception _exception;

    public CalculatorBasicReliabiltyStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"the initial failure intensity was (.*) failures per CPU hours, average number of failures is (.*) and the number of failures over infinite time is (.*)")]
    public void WhenTheInitialFailureIntensityWasFailuresPerCpuHoursAverageNumberOfFailuresIsAndTheNumberOfFailuresOverInfiniteTimeIs(int p0, int p1, int p2)
    {
        try
        {
            _result = _calculator.calculateFailureIntensity(p0, p1, p2);
        }
        catch (Exception e)
        {
            _exception = e;
        }
    }
    
    [When(@"the initial failure intensity was (.*) failures per CPU hours, average number of failures is (.*) and the number of failures over infinite time is (.*) after (.*)CPU hours")]
    public void WhenTheInitialFailureIntensityWasFailuresPerCpuHoursAverageNumberOfFailuresIsAndTheNumberOfFailuresOverInfiniteTimeIsAfterCpuHours(int p0, int p1, int p2, int p3)
    {
        try
        {
            _result = _calculator.calculateAverageExpectedFailure(p0, p1, p2, p3);
        }
        catch (Exception e)
        {
            _exception = e;
        }
    }

    [Then(@"the current failure intensity calculated should be (.*)")]
    public void ThenTheCurrentFailureIntensityCalculatedShouldBe(string exception)
    {
        if (_exception != null)
        {
            Assert.That(_exception.Message, Is.EqualTo(exception));
        }
    }
}