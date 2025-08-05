using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            // TpJeu();
            TpCalcule();
        }

        static void TpJeu()
        {
            Console.WriteLine(Jeu.Affiche());
        }

        static void TpCalcule()
        {
            Console.WriteLine(Calculateur.Calcule(1, 2, "+"));
        }
    }
}
