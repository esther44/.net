using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTPArticle
{
        public class Article
        {
            public int Reference { get; set; }
            public string Marque { get; set; }
            public double Prix { get; set; }

            public Article() { }

            public Article(int reference, string marque, double prix)
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
