using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count power x of 2
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class Pow2xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2,firstValue);
        }
    }
}
