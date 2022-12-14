using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("../../../../ICT3101_Calculator/MagicNumbers.txt")).Returns(new string[2] { "42","42" });
            _calculator = new Calculator();
        }
        //
        [Test]
        [TestCase(0, ExpectedResult = 84)]
        public double GenMagicNum_WhenGivenTests_Result(int a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader.Object);
            return result;
        }
    }
}
