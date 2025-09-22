using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpRest.Models
{
    public class Item
    {

        public int Ref { get; set; }
        public string Marque { get; set; }
        public double Prix { get; set; }

        public Item(int refArticle, string marque, double prix)
        {
            Marque = marque;
            Prix = prix;
            Ref = refArticle;
        }
        public Item() { }
        public override string ToString()
        {

            return Ref + "    " + Marque + "    " + Prix;
        }
    }
}
