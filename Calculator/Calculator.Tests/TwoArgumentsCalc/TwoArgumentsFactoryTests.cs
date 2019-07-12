using Calculator.TwoArgumentsCalc;
using NUnit.Framework;
using System;

namespace Calculator.Tests.OneArgumentCalc
{   
    [TestFixture]
    class TwoArgumentsFactoryTests
    {
        [TestCase("Division", typeof(DivisionCalculator))]
        [TestCase("Addition", typeof(AdditionCalculator))]
        [TestCase("Substraction", typeof(SubstractionCalculator))]
        [TestCase("Multiply", typeof(MultiplyCalculator))]
        [TestCase("PowXY", typeof(PowXYCalculator))]
        [TestCase("Logxy", typeof(LogxyCalculator))]

        public void CalculateTest(string name, Type type)

        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
