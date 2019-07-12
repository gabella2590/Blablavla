using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class Log2xTest
    {
        [TestCase(4, 0.5)]
        [TestCase(2, 1)]
        [TestCase(6, 0.386)]
        public void Log2xCalculator(
            double firstValue,
            double expected)
        {
            Log2xCalculator calculator = new Log2xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [Test]
        public void Log2xCalculator()

        {
            Log2xCalculator calculator = new Log2xCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
