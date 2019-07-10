using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalc
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "POW":
                    return new POWCalculator();
                case "Sin":
                    return new SINCalculator();
                case "Cos":
                    return new COSCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
