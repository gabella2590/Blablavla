using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class TwoArgumentsFactory
    {
    public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name) { 
            case "Addition":
                return new AdditionCalculator();
            case "Substraction":
                return new SubstractionCalculator();
            case "Multiply":
                return new MultiplyCalculator();
            case "Division":
                return new DivisionCalculator();
            default:
                throw new Exception("Неизвестная операция");
            }
        }

    }
    }

