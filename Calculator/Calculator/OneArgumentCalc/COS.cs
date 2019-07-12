using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count cos for x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class COSCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
