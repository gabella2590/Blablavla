using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class ACOSTests
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.571)]
        [TestCase(0.5, 1.047)]
        public void ACOSCalculator(
            double firstValue,
            double expected)
        {
            ACOSCalculator calculator = new ACOSCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void ACOSCalculator()
        {
            ACOSCalculator calculator = new ACOSCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }
}
