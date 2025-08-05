using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Utils
    {
        public static double ReadLineAsDouble()
        {
            double number;
            while (!Double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Un nombre est attendu, recommencez.");
            }
            return number;
        }
    }
}
