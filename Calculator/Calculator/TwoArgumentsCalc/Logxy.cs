using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TwoArgumentsCalc
{
        public class LogxyCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstValue, double secondValue)
            {
                return Math.Log(firstValue,secondValue);
            }        
    }
}
