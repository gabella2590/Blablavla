using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.TwoArgumentsCalc
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]

        public void MultiplyCalculator()

        {
            ITwoArgumentsCalculator calculator = new MultiplyCalculator();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(8, actual);

        }
    }
}
