using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tpWebForm1_ter.Model
{
    public class Article
    {

        public string Marque { get; set; }
        public double Prix { get; set; }

        public Article(string marque,double prix)
        {
            Marque = marque;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"{Marque} : {Prix} euros";
        }
    }
}