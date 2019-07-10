using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public class Log2xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(2,firstValue);
        }
    }
}
