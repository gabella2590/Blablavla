﻿using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class Pow10xTests
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        public void Pow2xCalculator(
            double firstValue,
            double expected)
        {
            Pow10xCalculator calculator = new Pow10xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
