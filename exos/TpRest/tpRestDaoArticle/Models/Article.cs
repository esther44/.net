using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpRestDaoArticle.Models
{
    public class Article
    {
        public int Reference { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }

        public Article() { }


        public Article(int reference, string marque, int prix)
        {
            Reference = reference;
            Marque = marque;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"{Reference} - {Marque} : {Prix}€";
        }
    }
}