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

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public Personne()
        {

        }

        public override string ToString()
        {
            return nom + " " + prenom + " " + age;
        }



        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }


        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }

        }

    }

}
