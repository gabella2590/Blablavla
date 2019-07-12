using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]

        public void AdditionCalculator()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            double actual = calculator.Calculate(1, 1);
            Assert.AreEqual(2,actual);
        }

        [TestCase(1, 1, 2)]
        [TestCase(3, 3, 6)]
        [TestCase(7, 7, 14)]
        public void AdditionCalculator(
            double firstValue,
            double secondValue,
            double expected)
        {
            AdditionCalculator calculator = new AdditionCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
