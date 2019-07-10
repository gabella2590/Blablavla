using System;


namespace Calculator.OneArgumentCalc
{
    public class ACOSCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
