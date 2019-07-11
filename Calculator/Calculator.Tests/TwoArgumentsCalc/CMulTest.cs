using NUnit.Framework;


namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class CMulTest
    {
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(3, 3, 9)]
        [TestCase(-7, 7, -49)]
        public void MultiplyCalculator(
            double firstValue,
            double secondValue,
            double expected)


        {
            MultiplyCalculator calculator = new MultiplyCalculator();
            double actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual);

        }
    }
}
