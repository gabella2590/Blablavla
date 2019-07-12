using System;
namespace Calculator
{
    /// <summary>
    /// function count result of division of x and y
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class DivisionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль запрещено");
            }
            double result = firstValue / secondValue;
            return result;
        }
    }
}
