using Calculator.OneArgumentCalc;
using NUnit.Framework;


namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class AtanXTests
    {
        [TestCase(1, 0.785)]
        [TestCase(2, 1.107)]
        [TestCase(4, 1.325)]
        public void AtanxCalculator(
            double firstValue,
            double expected)
        {
            AtanxCalculator calculator = new AtanxCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
