using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ProjetPersonneV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test4()
        {

            Adresse a1 = new Adresse(10, "rue de paris", "75013");
            Adresse a2 = new Adresse(101, "rue de lille", "75018");


            Personne p1 = new Personne("a", "b", 10, a1);
            //p1.
            Console.WriteLine(p1);
            p1.Adr = a2;
            Console.WriteLine(p1);

        }

        static void Test3()
        {

            Adresse a = new Adresse(10, "rue de paris", "75013");
            Personne p2 = new Personne("a", "b", 10, a);

            p2.Age = 11;

            Console.WriteLine(p2);
            Console.WriteLine(p2.Adr.Cp);

            p2.Adr.Numero = 200;
            Console.WriteLine(p2);
        }

        static void Test2()
        {
            Personne p1 = new Personne("a", "b", 10);


            Adresse a = new Adresse(10, "rue de paris", "75013");
            Personne p2 = new Personne("a", "b", 10, a);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }



        static void Test1()
        {
            Personne p1 = new Personne("a", "b", 10);
            Console.WriteLine(p1);

            Adresse a = new Adresse(10, "rue de paris", "75013");
            Console.WriteLine(a);

        }

    }
}
