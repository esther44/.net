using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Voiture voiture1 = new Voiture("abc", "VW", 2000);
            Voiture voiture2 = new Voiture("def", "Po", 3000);
            Voiture voiture3 = new Voiture("ghi", "Re", 4000);
            Voiture voiture4 = new Voiture("jkl", "Pe", 5000);

            voiture1.Vitesse = 100;
            voiture2.Vitesse = 200;
            voiture3.Vitesse = 300;
            voiture4.Vitesse = 400;

            Parking parking = new Parking("parking", 3);

            parking.Garer(voiture1);
            parking.Garer(voiture2);
            parking.Garer(voiture3);
            parking.Garer(voiture4);

            Console.WriteLine(parking.ToString());
        }
    }
}
