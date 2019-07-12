using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class PowTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        [TestCase(0, 0)]
        public void POWCalculator(
            double firstValue,
            double expected)
        {
            POWCalculator calculator = new POWCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
