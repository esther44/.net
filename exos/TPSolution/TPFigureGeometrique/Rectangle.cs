using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFigureGeometrique
{

    public class Rectangle: FigureGeometrique
    {

        private double longueur;
        private double largeur;


        public double Longueur
        {
            get => longueur;
            set => longueur = value;
        }

        public double Largeur
        {
            get => largeur;
            set => largeur = value;
        }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override double Aire()
        {
            return Longueur * Largeur;
        }

        public override double Perimetre()
        {
            return 2*(Longueur + Largeur);
        }

        public override string ToString()
        {
            return $"Rectangle : {base.ToString()}";
        }
    }
}
