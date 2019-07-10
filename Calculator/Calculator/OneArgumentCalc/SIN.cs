﻿using System;

namespace Calculator.OneArgumentCalc
{
    public class SINCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
             return Math.Sin (firstValue);
        }
    }
}
