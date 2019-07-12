using System;

namespace Calculator.OneArgumentCalc
{
    /// <summary>
    /// fabric using different classes to count one argument operations
    /// </summary>
    /// <param name="firstValue"></param>
    /// <returns></returns>
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
                case "Asin":
                    return new ASINCalculator();
                case "Acos":
                    return new ACOSCalculator();
                case "Powex":
                    return new PowexCalculator();
                case "Lnx":
                    return new LnxCalculator();
                case "Ctanx":
                    return new CtanxCalculator();
                case "Atanx":
                    return new AtanxCalculator();
                case "Log2x":
                    return new Log2xCalculator();
                case "Log10x":
                    return new Log10xCalculator();
                case "Pow2x":
                    return new Pow2xCalculator();
                case "Pow10x":
                    return new Pow10xCalculator();
                case "Minusx":
                    return new MinusxCalculator();
                case "Div1x":
                    return new Div1xCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
