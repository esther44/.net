using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServicePersonne.Model
{
    [DataContract]
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


        [DataMember]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }

        [DataMember]
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        [DataMember]
        public int Age
        {
            get { return age; }
            set { age = value; }

        }

    }
}