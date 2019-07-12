using System;



namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count power x of e
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class PowexCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            const double e = 2.71828f;
            return Math.Pow(e, firstValue);

        }
    }
}
