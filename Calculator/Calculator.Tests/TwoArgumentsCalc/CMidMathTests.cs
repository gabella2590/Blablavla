using Calculator.TwoArgumentsCalc;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class CMidMathTests
    {
        [TestCase(5, 1, 3)]
        [TestCase(3, 3, 3)]
        [TestCase(5, 7, 6)]
        public void MidMathCalculator(
            double firstValue,
            double secondValue,
            double expected)
        {
            MidMathCalculator calculator = new MidMathCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
