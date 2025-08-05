using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }

        static void Test4()
        {

            Personne p1 = new Personne("aa", "cc", 15);
            Personne p2 = new Personne("aa", "xx", 20);
            Personne p3 = new Personne("ab", "xx", 20);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
        }

        static void Test3()
        {
            Personne p1 = new Personne("aa", "cc", 15);
            Personne p2 = new Personne("aa", "xx", 20);
            Personne p3 = new Personne("aa", "aaaaa", 18);


            if (p1.Equals(p2))// this.nom.Equals(((Personne)obj).nom);
                Console.WriteLine("ok equals");
            else
                Console.WriteLine("NOT  equals");
        }


        static void Test1()
        {
            string s1 = "toto";
            Console.WriteLine("saisir s2");
            string s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("ok ==");

            if (s1.Equals(s2))
                Console.WriteLine("ok equals");
        }

        static void Test2()
        {

            Personne p1 = new Personne("aa", "bb", 10);
            Personne p2 = p1;
            Personne p3 = new Personne("aa", "bb", 10);

            if (p1 == p2)
                Console.WriteLine("p1 == p2 ok");

            if (p1 == p3)
                Console.WriteLine("p1 == p3 ok");

            //if(p1.Equals(p3))
            //    Console.WriteLine("ok equals");
        }
    }
}
