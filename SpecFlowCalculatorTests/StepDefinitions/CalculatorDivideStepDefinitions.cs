using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public class CalculatorDivideStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorDivideStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }
    
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(string p0)
        {
            // Check if the result is the string 
            var result = p0 == "positive_infinity" ? double.PositiveInfinity : double.Parse(p0);
            Assert.That(_result, Is.EqualTo(result));
        }
    
    }
}

