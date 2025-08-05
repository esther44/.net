using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonneV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            Traitement.M1(); // appel de méthodes static
            Traitement.M2();

            Traitement t = new Traitement(); // creation de nouvelle instance
            t.M3();
            t.M4();
        }

        static void Test2()
        {
            Personne p1 = new Personne("toto", 10);
            Personne p2 = new Personne("titi", 10);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine(Personne.Nom);


        }

        static void Test3()
        {
            Personne p1 = new Personne("toto", 10);
            Personne p2 = new Personne("titi", 10);
            new Personne();
            new Personne();

            Console.WriteLine(Personne.Compteur);
        }
    }
}
