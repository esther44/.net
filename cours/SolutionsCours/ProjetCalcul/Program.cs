using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    public class Program
    {
        static void Main(string[] args)
        {
            TPCalcule();
            TPJeu();
        }

        public static void TPCalcule()
        {
            Console.WriteLine("Nombre 1");
            double nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre 2");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Opérateur");
            string operateur = Console.ReadLine();

            double result = Calculateur.Calcule(nb1, nb2, operateur);
            Console.WriteLine(result);

        }

        static void TPJeu()
        {
            Console.Write(Jeu.Affiche());
        }
    }
}
