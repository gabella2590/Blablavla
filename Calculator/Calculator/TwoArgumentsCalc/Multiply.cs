

namespace Calculator
{
    /// <summary>
    /// function count multiplication result 
    /// </summary>

    public class MultiplyCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue * secondValue;
            return result;
        }
    }
}
