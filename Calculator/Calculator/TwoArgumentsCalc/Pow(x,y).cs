﻿using System;


namespace Calculator
{    /// <summary>
     /// function count x in power of y
     /// </summary>
     /// <param name="firstValue"></param>
     /// <returns></returns>
    public class PowXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            return result;
        }
    }
}
