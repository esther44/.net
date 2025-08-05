using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVilleV2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestV4();
        }

        static void TestV4()
        {
            Ville ville1 = new Ville("lille", "france", "paris", 1.8);
            Ville ville2 = new Ville("paris", "france", "PARIS", 8);
            Ville ville3 = new Ville("liverpool", "gb", "london", 3);

            Ville[] villes = { ville1, ville2, ville3 };

            foreach(Ville ville in villes)
            {
                Console.WriteLine(ville.ToString());
            }

        }
    }
}
