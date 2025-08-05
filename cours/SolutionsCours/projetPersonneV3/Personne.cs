using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonneV3
{
    class Personne
    {

        private static string nom = "DUPOND";
        private string prenom;
        private int age;

        private static int compteur = 0;

        public const int AGE_MAX = 120;

        public static int Compteur
        {
            get { return compteur; }
        }

        public static string Nom
        {

            get { return nom; }
        }

        static Personne()
        {
            Console.WriteLine("coucou cest moi");
        }

        public Personne()
        {
            compteur++;
        }

        public Personne(string prenom, int age)
        {
            this.prenom = prenom;
            this.age = age;
            compteur++;

        }



        public override string ToString()
        {
            return nom + "  " + prenom + "  " + age;
        }
    }
}
