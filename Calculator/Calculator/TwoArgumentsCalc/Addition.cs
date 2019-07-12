

namespace Calculator
{
    /// <summary>
    /// function count sum of x and y
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class AdditionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue + secondValue;
            return result;
        }
    }
}
