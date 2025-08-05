using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAbstract
{
    abstract class A
    {

        public abstract void M();

        public abstract void P();


        public void M1()
        {
            Console.WriteLine("je suis m1 de A");
        }

        public static void M2()
        {
            Console.WriteLine("je suis m2 static de A");
        }
    }
    abstract class B : A
    {
        public override void M()
        {
            Console.WriteLine("je suis m de B");

        }
        public void M3()
        {
            Console.WriteLine("je suis m3 de B");
        }

    }
    class D : B
    {
        public void M5()
        {
            Console.WriteLine("je suis m3 de B");
        }

        public override void P()
        {
            Console.WriteLine("je suis P de D");

        }
    }
    class C : A
    {

        public override void M()
        {
            Console.WriteLine("je suis m de C");

        }

        public override void P()
        {
            Console.WriteLine("je suis P de C");

        }

        public void M4()
        {
            Console.WriteLine("je suis m4 de C");
        }

    }

}
