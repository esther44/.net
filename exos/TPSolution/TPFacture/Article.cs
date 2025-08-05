using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacture
{
    public abstract class Article {

        public string Marque { get; set; }
        public abstract double Prix { get; }

        protected Article(string marque)
        {
            Marque = marque;
        }

        public override string ToString()
        {
            return $"{Marque} : {Prix} e";
        }
    }
}
