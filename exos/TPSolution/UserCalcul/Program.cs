using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //TpJeu();
           TpCalcul();
        }

        static void TpCalcul()
        {

            Console.WriteLine("Entrez les paramètres du calcul.");
            Console.WriteLine("Argument 1:");
            var a = Utils.ReadLineAsDouble();
            Console.WriteLine("Argument 2:");
            var b = Utils.ReadLineAsDouble();
            Console.WriteLine("Quelle opération parmi + - * /");
            var op = Console.ReadLine();

            Console.WriteLine("\n\t{0} {1} {2} = {3}", a, op, b, Calculateur.Calculate(a, b, op));

        }
    
        static void TpJeu()
        {
            Console.WriteLine(Jeu.Affiche());
        }
    }
}
