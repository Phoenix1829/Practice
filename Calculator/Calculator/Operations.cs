using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        public static double Sum(double x, double y) => x + y;

        public static double Diff(double x, double y) => x - y;

        public static double Mult(double x, double y) => x * y;

        public static double Div(double x, double y) => x / y;

        public static double Step(double x, double y) => Math.Pow(x, y);

        public static double Ostat(double x, double y) => x % y;

    }
}
