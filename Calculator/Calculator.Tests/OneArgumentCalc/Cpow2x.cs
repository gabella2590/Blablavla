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
    public class Cpow2xTest
    {
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(0, 1)]
        public void Pow2xCalculator(
            double firstValue,
            double expected)
        {
            Pow2xCalculator calculator = new Pow2xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}
