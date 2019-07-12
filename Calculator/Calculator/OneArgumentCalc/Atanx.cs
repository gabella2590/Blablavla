using System;


namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count arctg for x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class AtanxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
