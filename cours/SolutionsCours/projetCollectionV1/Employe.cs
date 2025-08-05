using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollectionV1
{
    class Employee
    {

        private string nom;
        private string prenom;
        private int age;

        public Employee()
        {

        }

        public Employee(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public string Nom
        {
            get { return nom; }
        }
        public string Prenom
        {
            get { return prenom; }
        }

        public override string ToString()
        {

            string reponse = nom + "   " + prenom + "   " + age;

            return reponse;
        }

    }
}
