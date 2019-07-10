using System;

namespace Calculator.OneArgumentCalc
{
    public class POWCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        { 
            return Math.Pow(firstValue,2);
        }
    }
}
