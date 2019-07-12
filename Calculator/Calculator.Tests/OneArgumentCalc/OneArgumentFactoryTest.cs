using Calculator.OneArgumentCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{
    class OneArgumentFactoryTest
    {
        [TestCase("POW", typeof(POWCalculator))]
        [TestCase("Sin", typeof(SINCalculator))]
        [TestCase("Cos", typeof(COSCalculator))]
        [TestCase("Tan", typeof(TANCalculator))]
        [TestCase("Asin", typeof(ASINCalculator))]
        [TestCase("Acos", typeof(ACOSCalculator))]
        [TestCase("Powex", typeof(PowexCalculator))]
        [TestCase("Lnx", typeof(LnxCalculator))]
        [TestCase("Ctanx", typeof(CtanxCalculator))]
        [TestCase("Atanx", typeof(AtanxCalculator))]
        [TestCase("Log2x", typeof(Log2xCalculator))]
        [TestCase("Log10x", typeof(Log10xCalculator))]
        [TestCase("Pow2x", typeof(Pow2xCalculator))]
        [TestCase("Pow10x", typeof(Pow10xCalculator))]
        [TestCase("Minusx", typeof(MinusxCalculator))]
        [TestCase("Div1x", typeof(Division1xCalculator))]

        public void CalculateTest(string name, Type type)

        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
