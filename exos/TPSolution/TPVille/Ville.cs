using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVille
{
    class Ville
    {
        public string nom;
        public string pays;
        public double nbHabitants;

        public string getInfos()
        {
            return nom + " " + pays + " " + nbHabitants;
        }
    }
}
