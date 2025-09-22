using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDaoArticles
{
    public class Article
    {

        public int Ref { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }

        public Article(int refArticle, string marque, int prix)
        {
            Marque = marque;
            Prix = prix;
            Ref = refArticle;
        }
        public Article() { }
        public override string ToString()
        {

            return Ref + "    " + Marque + "    " + Prix;
        }
    }
}
