using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEqualsArticle
{
    class Article:IComparable<Article>
    {
        string marque;
        decimal prix;

        string Marque {
            get => marque;
            set
            {
                marque = value;
            }
        }

        decimal Prix {
            get => prix;
            set
            {
                prix = value;
            }
        }

        public Article(string marque, decimal prix)
        {
            Marque = marque;
            Prix = prix;
        }

        public override bool Equals(object obj)
        {
            return this.marque.Equals(((Article)obj).marque);
        }

        public override int GetHashCode()
        {
            // Insensible à la casse
            return Marque.GetHashCode();
        }

        public int CompareTo(Article other)
        {
            // marques
            int cmp = string.Compare(Marque, other.Marque);
            Console.WriteLine(cmp);
            if (cmp != 0) return cmp;

            return Prix.CompareTo(other.Prix);
        }

        public override string ToString()
        {
            return $"Article : {Marque}, {Prix}";
        }
    }
}
