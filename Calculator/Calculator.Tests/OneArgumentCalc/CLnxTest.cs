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
    public class CLnxTest
    {
        [TestCase(1, 0)]
        [TestCase(4, 0.602)]
        [TestCase(100, 2)]
        public void LnxCalculator(
            double firstValue,
            double expected)
        {
            LnxCalculator calculator = new LnxCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}
