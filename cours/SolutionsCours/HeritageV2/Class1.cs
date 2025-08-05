using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageV2
{
    class A
    {

        public void M1()
        {
            Console.WriteLine("je suis m1 de de A");
            M2();
        }

        private void M2()
        {
            Console.WriteLine("je suis m2 de de A");
        }

        protected void M3()
        {
            Console.WriteLine("je suis m3 de de A");
        }
    }

    class B : A
    {

        //public void M1()
        //{
        //    Console.WriteLine("je suis m1 de de A");
        //}
        public void M4()
        {
            Console.WriteLine("je suis m3 de de A");

            M1();
            // M2();
            M3();
        }

    }
}
