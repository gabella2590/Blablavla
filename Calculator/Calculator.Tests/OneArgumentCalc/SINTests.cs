using Calculator.OneArgumentCalc;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class SINTests
    {
        [TestCase(1, 0.841)]
        [TestCase(0, 0)]
        [TestCase(0.5, 0.479)]
        public void SINCalculator(
            double firstValue,
            double expected)
        {
            SINCalculator calculator = new SINCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
