using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCalculette.Model{
    public class Calcul
    {
        private static double Sum(double a, double b) { return a + b; }
        private static double Difference(double a, double b) { return a - b; }
        private static double Product(double a, double b) { return a * b; }
        private static double Division(double a, double b) { return a / b; }


        public static double Calculate(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return Sum(a, b);
                case "-": return Difference(a, b);
                case "*": return Product(a, b);
                case "/": return Division(a, b);
                default: return Double.NaN;
            }
        }
    }
}
