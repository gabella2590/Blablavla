using System;


namespace Calculator.OneArgumentCalc
{
    public class ASINCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}
