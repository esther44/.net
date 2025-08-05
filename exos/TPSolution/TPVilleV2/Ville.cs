using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVilleV2
{
    class Ville
    {
        private readonly string nom;
        private readonly string pays;
        private readonly string capitale;
        private string taille;
        private double nbHabitants;
        private bool isCapitale =false;
    

        private const int nbHabitantsMin = 0;
        private const int nbHabitantsMax = 10;

        public double NbHabitants
        {
            get { return nbHabitants; }
            set
            {
                if (value > nbHabitantsMin && value < nbHabitantsMax)
                {
                    nbHabitants = value;
                    setTaille(nbHabitants);
                }
            }
        }


        //public string Pays
        //{
        //    get
        //    {
        //        return pays.ToUpper();
        //    }
        //}

        public string Nom => nom.ToLower();
        public string Pays => pays.ToUpper();
        public string Capitale => capitale;


        public Ville()
        {
        }

        public Ville(string ville, string pays, string capitale, double nbHabitants )
        {
            this.nom = ville;
            this.pays = pays;
            this.NbHabitants = nbHabitants;
            this.capitale = capitale;

            this.isCapitale = this.isCapitale = ville.ToLower() == capitale.ToLower();

        }

        private void setTaille(double nbHabitants)
        {
            if (nbHabitants <= 5)
            {
                this.taille = "petit";
            }
            else if (nbHabitants <= 7)
            {
                this.taille = "moyen";
            }
            else
            {
                this.taille = "grand";
            }
        }

        public override string ToString()
        {
            string statutCapitale = isCapitale ? Nom+ " est la capitale" : Nom+" n’est pas la capitale";
            return $"{Nom} {Pays} {Capitale} {NbHabitants} {taille}, {statutCapitale}";
        }
    }
}
