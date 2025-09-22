using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetRestDaoPersonne.Models
{
    public class Personne
    {
        public int Id
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }

        public string Nom
        {
            get;set;
        }

        public string Prenom
        {
            get; set;
        }

        public Personne(int id, string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Id = id;
        }
        public Personne() { }
        public override string ToString()
        {
            return Id + "    " + Nom + "    " + Prenom + "    " + Age;
        }
    }

}