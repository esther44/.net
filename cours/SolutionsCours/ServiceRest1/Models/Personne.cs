using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceRest1.Models
{
        public class Personne
        {
            private int id;
            private string nom;
            private string prenom;

            public Personne(int id, string nom, string prenom)
            {
                this.id = id;
                this.nom = nom;
                this.prenom = prenom;
            }
            public Personne()
            {

            }
            public int Id
            {
                get { return id; }
                set { id = value; }
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

            public override string ToString()
            {
                return id + " " + nom + " " + prenom;
            }
        }
    }