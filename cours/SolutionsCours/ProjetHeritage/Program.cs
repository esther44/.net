using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Test7()
        {

            X monX = new X();
            Console.WriteLine(monX.ToString());
        }

        static void Test4()
        {
            A monA = new A();
            C monC = new C();

            monA.MBis();
            monC.MBis();

        }

        static void Test3()
        {
            A monA = new A();
            B monB = new B();
            D monD = new D();

            monA.M();
            monB.M();
            monD.M();

        }

        static void Test2()
        {
            A monA = new A();

            B monB = new B();

            monA.M();
            monB.M();

        }


        static void Test1()
        {
            A monA = new A();
            monA.M1();

            B monB = new B();
            monB.M2();
            monB.M1();

            C monC = new C();
            monC.M3();
            monC.M1();

        }
    }
}
