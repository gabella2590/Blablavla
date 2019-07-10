using System;



namespace Calculator.OneArgumentCalc
{
    public class PowexCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            const double e = 2.71828f;
            return Math.Pow(e, firstValue);

        }
    }
}
