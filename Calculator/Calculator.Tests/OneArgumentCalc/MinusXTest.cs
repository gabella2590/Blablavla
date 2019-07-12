using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class MinusXTest
    {
        [TestCase(1, -1)]
        [TestCase(2, -2)]
        [TestCase(0, 0)]
        public void MinusxCalculator(
            double firstValue,
            double expected)
        {
            MinusxCalculator calculator = new MinusxCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
