﻿

namespace Calculator
{
    public class DivisionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue / secondValue;
            return result;
        }
    }
}
