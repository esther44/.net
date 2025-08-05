using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonneV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }

        static void Test4()
        {
            Personne p1 = new Personne("dupoNd", "ToTo", 10);

            Console.WriteLine(p1.ToString());
            p1.Age = 20;
            Console.WriteLine(p1.ToString());


        }

        static void Test2()
        {
            Personne p1 = new Personne("dupoNd", "ToTo", -20);
            Console.WriteLine(p1.ToString());
            p1.Age = 18;
            Console.WriteLine(p1.ToString());


            Console.WriteLine(p1.Nom);
            Console.WriteLine(p1.Prenom);


        }

        static void Test3()
        {
            Personne p1 = new Personne("dupond", "ToTo", 10);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1);
            string str1 = p1.ToString();
            string str2 = p1 + "";
        }


    }
}
