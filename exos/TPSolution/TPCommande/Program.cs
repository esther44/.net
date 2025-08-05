using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Console.WriteLine("nom ?");
            string nom = Console.ReadLine();

            foreach (Boisson x in Enum.GetValues(typeof(Boisson)))
                Console.WriteLine(x);

            string boisson = Console.ReadLine();
            Boisson b = (Boisson)Enum.Parse(typeof(Boisson), boisson);


            Console.WriteLine("plat ?");

            foreach (Plat x in Enum.GetValues(typeof(Plat)))
                Console.WriteLine(x);

            string plat = Console.ReadLine();
            Plat p = (Plat)Enum.Parse(typeof(Plat), plat);

            Console.WriteLine("dessert ?");

            foreach (Dessert x in Enum.GetValues(typeof(Dessert)))
                Console.WriteLine(x);

            string dessert = Console.ReadLine();
            Dessert d = (Dessert)Enum.Parse(typeof(Dessert), dessert);


            int total = (int)b + (int)p + (int)d;

                Console.WriteLine(nom + "\n" + boisson + " " + (int)b + " \n"
                    + plat + " " + (int)p + " \n"
                    + dessert + " " + (int)d + " \n"
                    + "total" + total);
        }
    }
}
