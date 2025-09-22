using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Article
    {
        public int RefArticle
        {
            get; set;
        }
        public int Prix
        {
            get; set;
        }

        public string Marque
        {
            get; set;
        }

        public Article(int refArticle, string marque, int prix)
        {
            Marque = marque;
            Prix = prix;
            RefArticle = refArticle;
        }
        public Article() { }
        public override string ToString()
        {

            return RefArticle + "    " + Marque.ToUpper() + "    " + Prix + "euros";
        }
    }
}
