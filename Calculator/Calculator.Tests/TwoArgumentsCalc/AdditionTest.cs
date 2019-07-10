using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]

        public void AdditionCalculator()
        {
            ITwoArgumentsCalculator calculator = new AdditionCalculator();
            double actual = calculator.Calculate(1, 1);
            Assert.AreEqual(2,actual);

        }
    }
}
