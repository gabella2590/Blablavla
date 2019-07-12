using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count power x of 10
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class Pow10xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10, firstValue);
        }
    }
}
