

namespace Calculator
{
    public class MultiplyCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue * secondValue;
            return result;
        }
    }
}
