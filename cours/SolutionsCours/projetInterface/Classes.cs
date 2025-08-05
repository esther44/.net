using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetInterface
{
    class A:I1,I2
    {
         void I1.M()        {
            Console.WriteLine("je suis M A de I1");
        }

        void I2.M()
        {
            Console.WriteLine("je suis M A de I2 ");
        }

        //public void M()
        //{
        //    Console.WriteLine("je suis M1 de A");
        //}

        public void M1()
        {
            Console.WriteLine("je suis M1 de A");
        }

        public void M2()
        {
            Console.WriteLine("je suis M2 de A");
        }

        public void MA()
        {
         
            Console.WriteLine("je suis MA de A");
        }

       
    }

    class B : I3
    {

        public void MB()
        {
            Console.WriteLine("je suis MB de B");
        }

        public void M1()
        {
            Console.WriteLine("je suis M1 de B");
        }

        public void M2()
        {
            Console.WriteLine("je suis M2 de B");
        }

        public void M3()
        {
            Console.WriteLine("je suis M3 de B");
        }

        public void M()
        {
            throw new NotImplementedException();
        }
    }
}
