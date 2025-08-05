using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            Adresse a = new Adresse("75000");
            //  Compte x = new Compte("ABCD")
  
            Personne p = new Personne("dupond", "toto", a, "ABCD");
            Console.WriteLine(p);

            p = null;

        }
    }
}
