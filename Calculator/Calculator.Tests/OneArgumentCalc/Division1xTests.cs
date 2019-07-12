using Calculator.OneArgumentCalc;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class Division1xTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        public void Div1xCalculator(
            double firstValue,
            double expected)
        {
            Division1xCalculator calculator = new Division1xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
