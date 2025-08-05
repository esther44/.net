using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }

        static void Test3()
        {
            B b1 = new B();
            b1.M1();
            b1.M2();
            b1.M3();

            I3 b2 = b1;
            I2 b3 = b2;

            b3.M2();

        }

        static void Test2()
        {
            A a1 = new A();

            I1 a2 = a1;
            I2 a3 = a1;

            a2.M1();
            a3.M2();
        }

        static void Test1()
        {
            A monA1 = new A();
            monA1.M1();
            monA1.MA();

            I1 monA2 = monA1;
            monA2.M1();

            A monA3 = (A)monA2;
            monA3.MA();

        }
    }
}
