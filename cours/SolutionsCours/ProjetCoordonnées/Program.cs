using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCoordonnées
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test3()
        {
            QuatreDim x = new QuatreDim();

        }

        static void Test2()
        {
            //TroisDim a = new TroisDim(10, 20, 30);
            //Console.WriteLine(a.ToString());
        }

        static void Test1()
        {
            DeuxDim a = new DeuxDim(10, 20);
            Console.WriteLine(a.ToString());
        }
    }
}
