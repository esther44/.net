using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Employes
{
    public class Employe
    {
        private string nom;
        private string prenom;


        public Employe(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;

        }

        public Employe()
        {

        }

        public override string ToString()
        {
            return nom + " " + prenom;
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
    }
}
