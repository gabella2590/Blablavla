using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SubstractionCalculator()
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);
        }
    }
}
