using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritageV3
{
    class Velo : Vehicule
    {
        public override string Avancer()
        {
            //return base.Avancer() + "  a 2 roues";
            return "je roule à deux roues";
        }
        public Velo(string marque, double prix) : base(marque, prix)
        {
        }
    }
}
