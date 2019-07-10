using System;

namespace Calculator.OneArgumentCalc
{
    public class COSCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
