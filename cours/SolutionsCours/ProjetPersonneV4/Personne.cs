using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        public Personne personne;

        private Adresse adr;

        public Adresse Adr
        {
            get
            {
                return adr;
            }
            set
            {
                adr = value;
            }
        }

        public int Age
        {

            get
            {
                return age;
            }
            set
            {
                age = value;
            }

        }



        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
        }



        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;

        }


        public Personne(string nom, string prenom, int age, Adresse adr)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adr = adr;

        }

        public override string ToString()
        {
            string res = this.nom + "   " + prenom + "  " + age + " \n";
            if (adr != null)
                res += adr.ToString();

            return res;
        }
    }
}
