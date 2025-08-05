using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetAssociation
{
    class Personne
    {
        private string nom;
        private string prenom;
        private Adresse adr;
        private Compte c;

        public Personne(string nom, string prenom, Adresse adr, string iban)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adr = adr;
            this.c = new Compte(iban);
        }
        public override string ToString()
        {
            return nom + "   " + prenom + "   " + adr + "    " + c;
        }
    }
    class Adresse
    {
        private string cp;

        public Adresse(string cp)
        {
            this.cp = cp;
        }
        public override string ToString()
        {
            return cp;
        }

    }
    class Compte
    {
        private string iban;

        public Compte(string iban)
        {
            this.iban = iban;
        }
        public override string ToString()
        {
            return iban;
        }


    }







}
