using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;


namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class ASINTests
    {
        [TestCase(1, 1.571)]
        [TestCase(0, 0)]
        [TestCase(0.5, 0.524)]
        public void ASINCalculator(
            double firstValue,
            double expected)
        {
            ASINCalculator calculator = new ASINCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [Test]
        public void ASINCalculator()
        {
            ASINCalculator calculator = new ASINCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }
}
