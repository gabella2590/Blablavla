using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public class POWCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        { 
            return Math.Pow(firstValue,2);
        }
    }
}
