using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]

        public void DivisionCalculator()

        {
            ITwoArgumentsCalculator calculator = new DivisionCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);

        }
    }
}
