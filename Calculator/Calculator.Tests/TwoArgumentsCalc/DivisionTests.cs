using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]

        public void DivisionCalculator()

        {
            DivisionCalculator calculator = new DivisionCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);
        }
    }
}
