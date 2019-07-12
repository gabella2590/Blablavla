using Calculator.TwoArgumentsCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class LogxyTests
    {
        [Test]
        public void LogxyCalculator()

        {
            LogxyCalculator calculator = new LogxyCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);
        }
    }
}
