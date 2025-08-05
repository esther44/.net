using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacture
{
    public enum BoissonTaille
    {
        Petite = 1,
        Moyenne = 2,
        Grande = 3,
    }

    public class Boisson:Article
    {
        BoissonTaille Taille { get; set; }

        public override double Prix => (int)Taille;

        public Boisson(string marque, BoissonTaille taille):base(marque)
        {
            Taille = taille;
        }

        public override string ToString()
        {
            return $"Boisson {Marque} : {Prix:F1} EUR - {Taille.ToString().ToLower()} : {(int)Taille} litre(s)";
        }
    }

}
