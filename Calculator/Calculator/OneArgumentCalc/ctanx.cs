using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public class CtanxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}
