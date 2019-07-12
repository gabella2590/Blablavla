

namespace Calculator.TwoArgumentsCalc
{
    /// <summary>
    /// function count average arithmetic mean
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class MidMathCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue+secondValue)/2;
        }
    }
}
