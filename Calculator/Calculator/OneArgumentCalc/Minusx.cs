using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public class MinusxCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return  (-firstValue);
        }
    }
}
