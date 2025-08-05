using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    public enum CB
    {
        visa = 5,
        MC = 10,
        AMEX = 15
    }

    class CompteCB : CompteSimple
    {
        public CB Carte { get; set; }

        public CompteCB(string titulaire, int solde, CB carte):base(titulaire, solde)
        {
            Carte = carte;
            Solde -= (int)carte;
        }

        public override string ToString()
        {
            return $"Compte CB Titulaire : {Titulaire}, Solde: {Solde}, Carte {Carte}";
        }
    }
}
