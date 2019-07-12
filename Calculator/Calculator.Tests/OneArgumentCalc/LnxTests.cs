using Calculator.OneArgumentCalc;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class LnxTests
    {
        [TestCase(1, 0)]
        [TestCase(4, 0.602)]
        [TestCase(100, 2)]
        public void LnxCalculator(
            double firstValue,
            double expected)
        {
            LnxCalculator calculator = new LnxCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
