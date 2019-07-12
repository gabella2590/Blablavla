using Calculator.TwoArgumentsCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class LogTests
    {
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 2)]
        [TestCase(27, 3, 3)]
        public void LogxyCalculator(
            double firstValue,
            double secondValue,
            double expected)

        {
            LogxyCalculator calculator = new LogxyCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void LogxyCalculator()

        {
            LogxyCalculator calculator = new LogxyCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}
