using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritageV3
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("je suis M1 de A");
        }
    }

    class B : A
    {
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
    }
}
