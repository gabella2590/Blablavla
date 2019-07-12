using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class CtanxTests
    {
        [TestCase(1, 0.642)]
        [TestCase(2, -0.457)]
        [TestCase(4, 0.863)]
        public void CtanxCalculator(
            double firstValue,
            double expected)
        {
            CtanxCalculator calculator = new CtanxCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}
