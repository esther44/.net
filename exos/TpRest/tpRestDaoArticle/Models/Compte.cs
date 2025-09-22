using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpRestDaoArticle.Models
{
    public class Compte
    {
        public string Rib { get; set; }
        public string Banque { get; set; }
        public double Solde { get; set; }

        public Compte() { }


        public Compte(string rib, string banque, int solde)
        {
            Rib = rib;
            Banque = banque;
            Solde = solde;
        }

        public override string ToString()
        {
            return $"{Rib} - {Banque} : {Solde}€";
        }
    }
}