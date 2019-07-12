

namespace Calculator
{
    /// <summary>
    /// result of addition x and y
    /// </summary>
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue + secondValue;
            return result;
        }
    }
}
