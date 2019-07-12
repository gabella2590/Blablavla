using System;


namespace Calculator.TwoArgumentsCalc
{
    /// <summary>
    /// function count x in power of 1/y
    /// </summary>
    public class Xpow1yCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,1/secondValue);
        }
    }
}
