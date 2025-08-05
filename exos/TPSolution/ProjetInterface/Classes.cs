using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterface
{
    class A : I1, I2
    {
        public void M1()
        {
            Console.WriteLine("Méthode M1 appelée de A");
        }

        public void M2()
        {
            Console.WriteLine("Méthode M2 appelée de A");
        }

        
        public void MA()
        {
            Console.WriteLine("Méthode MA appelée de A");
        }
    }

    class B : I3
    {

        public void M1()
        {
            Console.WriteLine("Méthode M1 appelée de B");
        }

        public void M2()
        {
            Console.WriteLine("Méthode M2 appelée de B");
        }

        public void M3()
        {
            Console.WriteLine("Méthode M3 appelée de B");
        }

        public void MB()
        {
            Console.WriteLine("Méthode MB appelée de B");
        }
    }
}
