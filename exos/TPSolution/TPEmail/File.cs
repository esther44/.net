using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmail
{
    class File
    {
        private string nom;
        private double taille;

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public double Taille
        {
            get => taille;
            set => taille = value;
        }

        public File(string nom, double taille)
        {
            Nom = nom;
            Taille = taille;
        }
    }
}
