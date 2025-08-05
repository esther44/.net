using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFigureGeometrique
{
   public abstract class FigureGeometrique
    {

        public abstract double Aire();
        public abstract double Perimetre();
 
        public override string ToString()
        {
            return $"Aire:{Aire()}, Périmètre : {Perimetre()}";
        }
    }
}
