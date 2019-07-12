using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class Log10xTests
    {
        [TestCase(10, 1)]
        [TestCase(100, 0.5)]
        [TestCase(200, 0.434)]
        public void Log10xCalculator(
            double firstValue,
            double expected)
        {
            Log10xCalculator calculator = new Log10xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [Test]
        public void Log10xCalculator()

        {
            Log10xCalculator calculator = new Log10xCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
