using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPersonneV2
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age = 1;

        private string status;// majeur mineur
        private bool isMajeur;//false

        public string Nom
        {
            get
            {
                return nom.ToUpper();
            }
        }

        public string Prenom
        {
            get
            {
                return prenom.ToLower();
            }
        }

        //var/const global
        private const int AGE_MINEUR = 18;
        public const int AGE_MIN = 0;
        public const int AGE_MAX = 120;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > AGE_MIN && value < AGE_MAX && age < value)
                {
                    age = value;
                    isMajeur = (age < AGE_MINEUR) ? false : true;
                    ComputeStatus();
                }
            }
        }
        private void ComputeStatus()
        {
            status = (!isMajeur) ? " MINEUR" : " MAJEUR";

        }

        //public int GetAge()
        //{
        //    return age;
        //}
        //public void SetAge(int age)
        //{
        //    if (age > 0 && age < 120)
        //        this.age = age;
        //}
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
            reponse += status;
            return reponse;
        }
    }
}
