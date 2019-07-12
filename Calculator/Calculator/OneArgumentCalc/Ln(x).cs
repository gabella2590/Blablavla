using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count LN using  x as argument
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class LnxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
