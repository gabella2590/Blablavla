using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        [TestCase(0, 1, 0)]
        [TestCase(3, 3, 1)]
        [TestCase(-7, 7, -1)]
        public void DivisionCalculator(
            double firstValue,
            double secondValue,
            double expected)


        {
            ITwoArgumentsCalculator calculator = new DivisionCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
    }
}
