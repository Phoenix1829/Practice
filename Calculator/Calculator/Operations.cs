using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ITwoArgumentsCalculator
    {
        double Calculate(double x, double y);
    }

    public class Operations
    {
        public class Sum : ITwoArgumentsCalculator
        {
            public double Calculate(double a, double b) => a + b;

        }

        public class Diff : ITwoArgumentsCalculator
        {

            public double Calculate(double a, double b) => a - b;

        }
        public class Mult : ITwoArgumentsCalculator
        {

            public double Calculate(double a, double b) => a * b;

        }
        public class Div : ITwoArgumentsCalculator
        {

            public double Calculate(double a, double b) => a / b;

        }
        public class Pow : ITwoArgumentsCalculator
        {
            public double Calculate(double a, double b) => Math.Pow(a, b);

        }

        public class Ostat : ITwoArgumentsCalculator
        {
            public double Calculate(double a, double b) => a % b;

        }
    }

    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator Creator(string OperationName)
        {
            switch (OperationName)
            {
                case "Sum":
                    return new Operations.Sum();
                case "Diff":
                    return new Operations.Diff();
                case "Mult":
                    return new Operations.Mult();
                case "Div":
                    return new Operations.Div();
                case "Pow":
                    return new Operations.Pow();
                case "Ostat":
                    return new Operations.Ostat();
                default:
                    throw new Exception();
            }
        }
    }
}