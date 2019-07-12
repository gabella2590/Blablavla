namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// function count negative x
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
    public class MinusxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return  (-firstValue);
        }
    }
}
