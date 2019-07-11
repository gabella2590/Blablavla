using System;


namespace Calculator.OneArgumentCalc
{
    public class ACOSCalculator : IOneArgumentCalculator
    {
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
