﻿using System;


namespace Calculator.OneArgumentCalc
{
    public class ACOSCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// function count arccos for x
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Аргумент  вне допустимых значений");
            }
            return Math.Acos(firstValue);
        }
    }
}
