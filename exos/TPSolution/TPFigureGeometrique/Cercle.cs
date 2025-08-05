using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFigureGeometrique
{
    class Cercle: FigureGeometrique
    {
        private double rayon;
        public double Rayon
        {
            get => rayon;
            set => rayon = value;
        }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public override double Aire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }

        public override double Perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public override string ToString()
        {
            return $"Cercle d'aire : {base.ToString()}";
        }
    }
}
