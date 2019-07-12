using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count Log10 using  x as argument
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class Log10xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Аргумент логарифма не равен нулю");
            }
            return Math.Log(10, firstValue);
        }
    }
}
