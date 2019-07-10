using System;

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
            case "PowXY":
                return new PowXYCalculator();
            default:
                throw new Exception("Неизвестная операция");
            }
        }

    }
    }

