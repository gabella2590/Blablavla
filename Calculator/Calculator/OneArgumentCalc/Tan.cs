using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count tan of x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class TANCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
