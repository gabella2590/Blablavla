using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count sin of x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class SINCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
             return Math.Sin (firstValue);
        }
    }
}
