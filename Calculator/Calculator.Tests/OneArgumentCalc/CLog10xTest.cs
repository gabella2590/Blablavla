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
    public class CLog10xTest
    {
        [TestCase(10, 1)]
        [TestCase(100, 0.5)]
        [TestCase(200, 0.434)]
        public void Log10xCalculator(
            double firstValue,
            double expected)
        {
            Log10xCalculator calculator = new Log10xCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}
