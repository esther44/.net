using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritage
{

    class X
    {

        public override string ToString()
        {
            //  return base.ToString(); 
            return "je suis la classe X";
        }

    }

    class A
    {
        public void M1()
        {
            Console.WriteLine("je suis M1 de A");
        }

        public void M()
        {
            Console.WriteLine("je suis M de A");
        }

        public void MBis()
        {
            Console.WriteLine("je suis MBis de A");
        }

    }

    class B : A
    {

        public new void M()
        {
            Console.WriteLine("je suis M de B");
        }

        public void M2()
        {
            Console.WriteLine("je suis M2 de B");
        }
    }

    class C : A
    {
        public void M3()
        {
            Console.WriteLine("je suis M3 de C");
        }

        public new void MBis()
        {
            base.MBis();
            Console.WriteLine("je suis MBis de C");
        }

    }

    class D : B
    {

        public new void M()
        {
            Console.WriteLine("je suis M de D");
        }

        public void M4()
        {
            Console.WriteLine("je suis M4 de D");
        }
    }

}
