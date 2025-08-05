using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
        }
        static void Test1()
        {
            Singleton s1 = Singleton.Instance;
            s1.Nom = "toto";
            Console.WriteLine(s1.Nom);
        }
        static void Test2()
        {
            Singleton s2 = Singleton.Instance;
            s2.Nom = "titi";

        }
        static void Test3()
        {
            Singleton s3 = Singleton.Instance;
            Console.WriteLine(s3.Nom);
            // Console.WriteLine(Singleton.Instance.Nom);
        }​
    }
}
