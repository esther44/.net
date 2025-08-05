using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFigureGeometrique
{
    class Carre:Rectangle
    {

        public Carre(double cote):base(cote, cote)
        {

        }

        public override string ToString()
        {
            return $"Carré : {base.ToString()}";
        }
    }
}
