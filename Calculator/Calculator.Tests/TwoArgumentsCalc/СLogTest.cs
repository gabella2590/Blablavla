using Calculator.TwoArgumentsCalc;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class CLogTest
    {
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 2)]
        [TestCase(27, 3, 3)]
        public void DivisionCalculator(
            double firstValue,
            double secondValue,
            double expected)


        {
            LogxyCalculator calculator = new LogxyCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
    }
}
