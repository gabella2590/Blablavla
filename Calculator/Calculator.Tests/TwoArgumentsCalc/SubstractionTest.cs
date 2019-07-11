using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class SubstractionTest
    {
        [Test]

        public void SubstractionCalculator()

        {
            ITwoArgumentsCalculator calculator = new SubstractionCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);

        }
    }
}
