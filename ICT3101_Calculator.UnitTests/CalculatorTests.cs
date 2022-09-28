namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        IFileReader fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            fileReader = new FileReader();
        }

        [Test]
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(11, 0, ExpectedResult = 11)]
        [TestCase(5, 20, ExpectedResult = 25)]
        public double Add_WhenAddingTwoNumbers_ResultEqualToSum(double a, double b)
        {
            //// Assert
            //Assert.That(result, Is.EqualTo(30));
            double result = _calculator.Add(10, 20);
            return _calculator.Add(a, b);
        }

        [Test]
        [TestCase(20, 10, ExpectedResult = 10)]
        [TestCase(0, 10, ExpectedResult = -10)]
        public double Substract_WhenSubtractingTwoNumbers_ResultEqualToSum(double a, double b)
        {
            //// Assert
            //Assert.That(result, Is.EqualTo(10));

            double result = _calculator.Subtract(a, b);

            return result;
        }

        [Test]
        [TestCase(2, 4, ExpectedResult = 8)]
        [TestCase(0, 10, ExpectedResult = 0)]
        public double Multiply_WhenMultiplyingTwoNumbers_ResultEqualToSum(double a, double b)
        {
            double result = _calculator.Multiply(a, b);
            return result;
        }

        [Test]
        [TestCase(4, 4, ExpectedResult = 1)]
        [TestCase(4, 2, ExpectedResult = 2)]
        public double Divide_WhenDividingTwoNumbers_ResultEqualToSum(double a, double b)
        {
            double result = _calculator.Divide(a, b);
            //Assert.That(result, Is.EqualTo(2));
            return result;
        }


        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        //{
        //    Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        //}

        [Test]
        [TestCase(-5, 0)]
        public void Factorial_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(5, 0)]
        public void Factorial_InputNonNegative(double a, double b)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
                result *= i;

            double calculatedResult = _calculator.Factorial(a);
            Assert.That(calculatedResult, Is.EqualTo(result));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        [TestCase(-1, 1)]
        public void Triangle_ZeroAndNegativeInputs_Exception(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                Assert.That(() => _calculator.Triangle(a, b), Throws.ArgumentException);
            }
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        public void Triangle_ValidInputs(double a, double b, double expected)
        {
            double result = _calculator.Triangle(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(-2, 0)]
        public void Circle_ZeroAndNegativeInputs_Exception(double a, double b)
        {
            if (a <= 0) Assert.That(() => _calculator.Circle(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, 0, 3.0d)]
        [TestCase(20, 0, 1200.0d)]
        public void Circle_ValidRadiusInputs(double a, double b, double expected)
        {
            double result = _calculator.Circle(a);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 5, ExpectedResult = 120)]
        [TestCase(5, 4, ExpectedResult = 120)]
        [TestCase(5, 3, ExpectedResult = 60)]
        public double UnknownFunctionA_WhenGivenTests_Result(double a, double b)
        {
            double result = _calculator.UnknownFunctionA(a, b);
            return result;
        }

        [Test]
        [TestCase(-4, 5)]
        [TestCase(4, 5)]
        public void UnknownFunctionA_WhenGivenTests_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.UnknownFunctionA(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(5, 5, ExpectedResult = 1)]
        [TestCase(5, 4, ExpectedResult = 5)]
        [TestCase(5, 3, ExpectedResult = 10)]
        public double UnknownFunctionB_WhenGivenTests_Result(double a, double b)
        {
            double result = _calculator.UnknownFunctionB(a, b);
            return result;
        }

        [Test]
        [TestCase(-4, 5)]
        [TestCase(4, 5)]
        public void UnknownFunctionB_WhenGivenTests_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.UnknownFunctionB(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, ExpectedResult=12)]
        [TestCase(2, ExpectedResult= 12)]
        [TestCase(8, ExpectedResult = 2)]
        public double GenMagicNum_WhenGivenTests_Result(int a)
        {
            double result = _calculator.GenMagicNum(a, fileReader);
            return result;
        }

    }
}