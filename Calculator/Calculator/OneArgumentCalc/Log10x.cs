using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public class Log10xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Аргумент логарифма не равен нулю");
            }
            return Math.Log(10, firstValue);
        }
    }
}
