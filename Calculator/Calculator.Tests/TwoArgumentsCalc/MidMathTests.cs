using Calculator.TwoArgumentsCalc;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{

        [TestFixture]
        public class MidMathTests
        {
            [TestCase(5, 1, 3)]
            [TestCase(3, 3, 3)]
            [TestCase(5, 7, 6)]
            public void MidMathCalculator(
                double firstValue,
                double secondValue,
                double expected)
            {
                MidMathCalculator calculator = new MidMathCalculator();
                double actual = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actual);
            }
            [Test]
       public void MidMathCalculator()
        {
            MidMathCalculator calculator = new MidMathCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(3, actual);
        }
    }
}
