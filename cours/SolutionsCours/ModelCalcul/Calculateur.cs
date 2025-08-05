using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Calculateur
    {

        public static double Calcule(double nb1, double nb2, string operateur)
        {

            switch (operateur)
            {
                case "+":
                    return Addition(nb1, nb2);
                case "-":
                    return Soustraction(nb1, nb2);
                case "/":
                    return Division(nb1, nb2);
                case "*":
                    return Multiplication(nb1, nb2);
                default:
                    Console.WriteLine("Opérateur non reconnu");
                    return Double.NaN;
            }

        }

        static double Addition(double nb1, double nb2)
        {
            return nb1 + nb2;
        }

        static double Soustraction(double nb1, double nb2)
        {
            return nb1 - nb2;
        }

        static double Division(double nb1, double nb2)
        {
            return nb1 / nb2;
        }

        static double Multiplication(double nb1, double nb2)
        {
            return nb1 * nb2;
        }
    }
}
