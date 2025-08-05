using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPersonneV1
{
    class Personne
    {
        //attributs 
        private string nom = "NA";
        private string prenom = "NC";

        private int age;
        private const int ageMin = 0;
        private const int ageMax = 120;

        //constructeur
        //1.implicite-non codé
        //2.constructeur par defaut - codé - sans parametre
        //3.contructeur d initialisation - codé - avec parametre
        //

        //public void setAge(int age)
        //{
        //    if (age > 0 && age < 120) p2.setAge(22);
        //    this.age = age;
        //}

        //public int getAge()
        //{
        //   return  this.age;
        //}

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


        public int Age
        {
            get { return age; }
            set
            {
                if (value > ageMin && value < ageMax)
                    age = value;
            }
        }


        // constructeur par defaut
        public Personne()
        {
        }

        // contructeur d initialisation
        //public Personne(string nom, string prenom )
        //{
        //    this.nom = nom;
        //    this. prenom = prenom;
        //}

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.Age = age;
        }

        private string Compute()
        {
            string reponse = "";
            reponse += (this.nom == null) ? " NOM NULL " : Nom.ToUpper();
            reponse += (prenom == null) ? " PRENOM NULL " : Prenom.ToLower();
            reponse += "" + age;
            return reponse;
        }

        public string GetInfo()
        {
            return Compute();
        }


    }
}
