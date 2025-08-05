using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnumere
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test5()
        {
            Console.WriteLine("java csharp cpp pyhton");
            foreach (Formation x in Enum.GetValues(typeof(Formation)))
                Console.WriteLine(x);

            string choix = Console.ReadLine();
            Formation f = (Formation)Enum.Parse(typeof(Formation), choix);
            Console.WriteLine("prix   " + (int)f);
        }

        static void Test4()
        {
            Console.WriteLine("java csharp cpp pyhton");
            string choix = Console.ReadLine();
            Formation f = (Formation)Enum.Parse(typeof(Formation), choix);
            Console.WriteLine("prix   " + (int)f);
        }

        static void Test3()
        {
            Console.WriteLine(Formation.csharp + "" + (int)Formation.csharp);
        }

        static void Test2()
        {
            Console.WriteLine(Civilite.mme.ToString());
            string str = "bonjour  " + Civilite.mme;
            Console.WriteLine(str);

            Civilite x = Civilite.mr;
            Console.WriteLine((int)x);

        }


        static void Test1()
        {
            Console.WriteLine(Semaine.Dimanche);
            Console.WriteLine(Semaine.Dimanche.ToString());
            Console.WriteLine((int)Semaine.Dimanche);
        }
    }
}
