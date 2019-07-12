

namespace Calculator
{
    /// <summary>
    /// function count substraction result
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class SubstractionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue - secondValue;
            return result;
        }
    }
}
