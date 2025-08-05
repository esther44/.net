using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }

        static void Test3()
        {
            Velo velo = new Velo();
            Velo velo2 = new Velo("LaPierre", 5000);
            Console.WriteLine(velo.Avancer());
            Console.WriteLine(velo.ToString());
            Console.WriteLine(velo2.Avancer());
            Console.WriteLine(velo2.ToString());

            Bateau bateau = new Bateau("Marquebateau", 12000);
            Bateau bateau2 = new Bateau("Marquebateau2", 13000, Bateau.Taille.moyen);

            Console.WriteLine("bateau : "+ bateau.Avancer() + bateau.ToggleAmarre());
            Console.WriteLine("bateau2 : "+ bateau2.Avancer() + bateau2.ToggleAmarre());
            Console.WriteLine(bateau.ToString());
            Console.WriteLine(bateau2.ToString());
        }
        static void Test2()
        {
            Voiture voiture = new Voiture("VW", 12000);
            //Console.WriteLine(voiture.Avancer());
            voiture.ToggleGps();
            Console.WriteLine(voiture.ToString());
            voiture.ToggleGps();
            Console.WriteLine(voiture.ToString());
        }

        static void Test()
        {
            Voiture voiture = new Voiture();
            Velo velo = new Velo();
            //Bateau bateau = new Bateau();
            Console.WriteLine(voiture.Avancer());
            Console.WriteLine(velo.Avancer());
            //Console.WriteLine(bateau.Avancer());
        }
    }
}
