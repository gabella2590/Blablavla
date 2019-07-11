﻿using Calculator.TwoArgumentsCalc;
using NUnit.Framework;


namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class LogxyTest
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
