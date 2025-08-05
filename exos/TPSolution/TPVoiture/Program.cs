using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Voiture voiture = new Voiture("abcd", "peugeot");
            voiture.Vitesse = 100;
            voiture.Vitesse = 125;
            voiture.Vitesse = 0;
            Console.WriteLine(voiture.ToString());

            Voiture voiture1 = new Voiture("ddd", "renault");
            voiture1.Vitesse = 20;
            voiture1.Vitesse = 200;
            voiture1.Vitesse = 201;
            Console.WriteLine(voiture1.ToString());

        }
    }
}
