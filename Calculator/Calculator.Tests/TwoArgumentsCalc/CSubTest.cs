using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class CSubTest
    {
        [Test]
        [TestCase(2, 1, 1)]
        [TestCase(3, 3, 0)]
        [TestCase(-7, 7, -14)]
        public void SubstractionCalculator(
            double firstValue,
            double secondValue,
            double expected)


        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
    }
}
