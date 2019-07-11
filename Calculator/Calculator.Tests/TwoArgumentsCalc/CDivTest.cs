using NUnit.Framework;
using System;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class CDivTest
    {
        [TestCase(0, 1, 0)]
        [TestCase(3, 3, 1)]
        [TestCase(-7, 7, -1)]
        public void DivisionCalculator(
            double firstValue,
            double secondValue,
            double expected)


        {
            DivisionCalculator calculator = new DivisionCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void DivisionCalculator()
            

        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.Throws<Exception>(()=>calculator.Calculate(1,0));

        }
    }
}
