using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritageV3
{
    class Bateau : Vehicule
    {
        private int nbPlace = 0;

        public Bateau(string marque, double prix) : base(marque, prix) { }

        public Bateau(string marque, double prix, int places) : base(marque, prix)
        {
            nbPlace = places;
        }

        public override string Avancer()
        {
            return "Je flotte";
        }

        public override string ToString()
        {
            return base.ToString() + " avec " + nbPlace + " places";
        }
    }
}
