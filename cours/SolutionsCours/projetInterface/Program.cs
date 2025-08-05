using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }

        static void Test4()
        {
            A a1 = new A();
            I1 a2 = a1;
            a2.M();

            I2 a3 = a1;
            a3.M();


           I1 x = new A();
            x.M();

            I2 y = (I2)x;

        }

        static void Test3()
        {
            B b1 = new B();
            I3 b2 = b1;
            I2 b3 = b2;


            B x = (B)b3;

        }
        static void Test2()
        {
            A a1 = new A();

            I1 a2 = a1;
            I2 a3 = a1;
          


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
