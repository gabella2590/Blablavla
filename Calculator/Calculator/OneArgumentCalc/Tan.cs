using System;

namespace Calculator.OneArgumentCalc
{
    public class TANCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
