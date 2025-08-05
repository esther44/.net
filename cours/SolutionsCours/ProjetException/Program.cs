using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetException
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDiv();
        }

        static void TestDiv()
        {
            try
            {
                Console.WriteLine("num");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("denom");
                int denom = Convert.ToInt32(Console.ReadLine());
                int res = Calcul.Div(num, denom);
                Console.WriteLine(res);
            }
            catch(Exception e)
            {
                Console.WriteLine("problème de saisie" + e);
            }
            Console.WriteLine("a bientôt");
        }

        static void Test2()
        {
            string str = null;
            Console.WriteLine(str.ToUpper());
        }

        static void Test1()
        {
            Console.WriteLine("age");
            int age = Convert.ToInt32(Console.ReadLine());
            age++;
            Console.WriteLine("dans 1 an " + age);
        }
    }
}
