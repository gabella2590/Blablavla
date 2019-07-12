using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplyCalculator()
        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(8, actual);
        }
    }
}
