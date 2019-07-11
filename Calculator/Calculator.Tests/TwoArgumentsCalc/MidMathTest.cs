using Calculator.TwoArgumentsCalc;
using NUnit.Framework;


namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class MidMathTest
    {
        [Test]

        public void MidMathCalculator()

        {
            MidMathCalculator calculator = new MidMathCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(3, actual);

        }
    }
}
