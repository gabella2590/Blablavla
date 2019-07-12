using Calculator.OneArgumentCalc;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalc
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(1, 0.540)]
        [TestCase(2, -0.416)]
        [TestCase(4, -0.653)]
        public void COSCalculator(
            double firstValue,
            double expected)
        {
            COSCalculator calculator = new COSCalculator();
            double actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
