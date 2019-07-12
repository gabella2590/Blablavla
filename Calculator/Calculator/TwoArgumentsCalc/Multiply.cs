

namespace Calculator
{
    /// <summary>
    /// function count multiplication result 
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class MultiplyCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue * secondValue;
            return result;
        }
    }
}
