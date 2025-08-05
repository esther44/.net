using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollectionV1
{
    class Personne: IComparable<Personne>
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
            get { return age; }
            set
            {

                age = value;

            }
        }

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;

        }


        public Personne()
        {

        }

        public override string ToString()
        {
            string reponse = "";
            reponse += this.Nom + "  ";
            reponse += Prenom + "  ";
            reponse += age + "  ";

            return reponse;
        }

        public int CompareTo(Personne other)
        {
            return this.nom.CompareTo(other.nom);
        }
    }
}
