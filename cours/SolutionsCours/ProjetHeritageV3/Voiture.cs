using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritageV3
{
    

    class Voiture : Vehicule
    {
        private bool isGpsOn = false;

        public Voiture(string marque, double prix) : base(marque, prix) { }

        public void gpsOnOff()
        {
            isGpsOn = !isGpsOn;
        }

        public override string Avancer()
        {
            return "je roule";
        }
    }
}
