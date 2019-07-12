using System;

namespace Calculator.TwoArgumentsCalc
{
    /// <summary>
    /// function count log of x using y as argument
    /// </summary>

    public class LogxyCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstValue, double secondValue)
            {
            if (secondValue == 0)
            {
                throw new Exception("Основание алгоритма не равно нулю");
            }
            return Math.Log(firstValue,secondValue);
            }        
    }
}
