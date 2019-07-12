

namespace Calculator.OneArgumentCalc
{        /// <summary>
         /// function count 1 divided on x
         /// </summary>
         /// <param name="firstValue"></param>
         /// <returns></returns>
    public class Division1xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (1/firstValue);
        }
    }
}
