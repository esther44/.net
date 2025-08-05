using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonneV3
{
    class Traitement
    {

        // méthode de class
        public static void M1()
        {
            Console.WriteLine("je suis M1 static");
        }

        // méthode de class
        public static void M2()
        {
            Console.WriteLine("je suis M2 static");
        }

        // méthode d'instance
        public void M3()
        {
            Console.WriteLine("je suis M3 non static");
        }

        // méthode d'instance
        public void M4()
        {
            Console.WriteLine("je suis M4 non static");
        }


    }
}
