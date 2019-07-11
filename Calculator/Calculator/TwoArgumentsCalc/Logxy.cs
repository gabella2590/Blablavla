using System;

namespace Calculator.TwoArgumentsCalc
{
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
