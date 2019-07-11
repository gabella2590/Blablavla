using Calculator.TwoArgumentsCalc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class LogxyTest
    {
        [Test]

        public void LogxyCalculator()

        {
            ITwoArgumentsCalculator calculator = new LogxyCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual);

        }
    }
}
