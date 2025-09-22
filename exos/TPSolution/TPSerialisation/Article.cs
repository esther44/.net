using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSerialisation
{
    [Serializable]
    class Article
    {

        public string Marque { get; set; }
        public double Prix { get; set; }

        public Article(string marque, double prix)
        {
            Marque = marque;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"{Marque} : {Prix} e";
        }
    }
}
