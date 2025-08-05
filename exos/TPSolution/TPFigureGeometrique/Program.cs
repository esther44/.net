using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFigureGeometrique
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureGeometrique[] tab = new FigureGeometrique[3];
            tab[0] = new Rectangle(10, 3);
            tab[1] = new Carre(4.5);
            tab[2] = new Cercle(3);

            foreach(FigureGeometrique f in tab)
            {
                Console.WriteLine(f);
            }
        }
    }
}
