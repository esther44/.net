using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Test5()
        {

            Generix<int, string> x = new Generix<int, string>(10, "toto");

            Console.WriteLine(x.A + "    " + x.B);

        }

        static void Test4()
        {
            Generique<int> x1 = new Generique<int>(10);
            Console.WriteLine(x1.A);
            x1.A = 15;
            Console.WriteLine(x1.A);
            x1.A = 15;

            Generique<Personne> x2 = new Generique<Personne>(new Personne("aa", "bb", 10));

            Console.WriteLine(x2.A.Nom);
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

        static void Test2()
        {
            Generic x1 = new Generic(10);
            Generic x2 = new Generic("toto");
            Generic x3 = new Generic(new Personne("aa", "bb", 10));

            Console.WriteLine(x1.A);
            Console.WriteLine(x2.A);



            object p = x3.A;

            Personne p1 = (Personne)p;


            Personne p2 = (Personne)x3.A;

            Console.WriteLine(((Personne)x3.A).Nom);

            Console.WriteLine(x3.A);

        }

        static void Test1()
        {
            // var x...x=2
            int a = 10;
            object b = 10;

            int a2 = (int)b;

            string s1 = "toto";
            object s2 = "titi";


            Personne p1 = new Personne("aa", "zz", 10);
            //p1.Nom
            object p2 = new Personne("xx", "yy", 10);
            Personne p3 = (Personne)p2;
            Console.WriteLine(p1);
            Console.WriteLine(p2);



        }
    }
}
