using System;

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
                case "Tan":
                    return new TANCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
