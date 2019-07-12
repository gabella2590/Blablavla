using System;


namespace Calculator.OneArgumentCalc
{
        /// <summary>
        /// function count ctan for x
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
    public class CtanxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}
