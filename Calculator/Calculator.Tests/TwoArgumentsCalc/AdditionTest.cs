using NUnit.Framework;



namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]

        public void AdditionCalculator()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            double actual = calculator.Calculate(1, 1);
            Assert.AreEqual(2,actual);

        }
    }
}
