﻿using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class TanTest
    {
        [TestCase(1, 1.557)]
        [TestCase(0, 0)]
        [TestCase(0.5, 0.546)]
        public void TANCalculator(
            double firstValue,
            double expected)
        {
            TANCalculator calculator = new TANCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
