using System;


namespace Calculator
{
    public class PowXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            return result;
        }
    }
}
