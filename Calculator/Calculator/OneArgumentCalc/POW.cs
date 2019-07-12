using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count 2nd power for x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class POWCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        { 
            return Math.Pow(firstValue,2);
        }
    }
}
