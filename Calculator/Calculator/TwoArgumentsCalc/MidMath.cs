

namespace Calculator.TwoArgumentsCalc
{
    /// <summary>
    /// function count average arithmetic mean
    /// </summary>
    public class MidMathCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue+secondValue)/2;
        }
    }
}
