using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Model
{
     public class Personne
    {
        private string nom;
        private string prenom;
        private int age;




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

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;

        }


        public override string ToString()
        {
            string res = this.nom + "   " + prenom + "  " + age + " \n";

            return res;
        }
    }
}