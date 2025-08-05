using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVille
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("St Truc", "France", 3.2);
            Test("St Bart", "Belgique", 2.3);
            Test("St Tyt", "Espagne", 9.8);
            Test("St Jo", "Angleterre", 44);
        }

        static void Test(string nom, string Pays, double nbHabitants)
        {
            Ville ville = new Ville();
            ville.nbHabitants = nbHabitants;
            ville.nom = nom;
            ville.nbHabitants = nbHabitants;

            Console.WriteLine(ville.getInfos());
        }
    }
}
