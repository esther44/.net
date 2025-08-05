using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacture
{
    class Ligne
    {
        public int Quantite { get; set; }
        public Article Article { get; set; }
        public double PrixLigne => Article.Prix * Quantite;
    

        public Ligne(int quantite, Article article)
        {
            Quantite = quantite;
            Article = article;
        }

        public override string ToString()
        {
            return $"{Article.Marque} {Article.Prix} *{Quantite} = {PrixLigne}";
        }
    }
}
