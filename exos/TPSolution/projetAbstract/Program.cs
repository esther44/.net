using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

            static void Test3()
            {

                C monC = new C();
                D monD = new D();



            }

            static void Test2()
        {
            //B monB = new B();
            //monB.M1();
            //monB.M();
            //monB.M3();
        }

        static void Test1()
        {
            //A monA = new A();
            //monA.M1();

            A.M2();
            //B monB = new B();
            //monB.M1();
            //monB.M3();

        }
    }
}
