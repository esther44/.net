using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacture
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Facture facture = new Facture("Esther \n");
            
            Boisson article1 = new Boisson("coca", BoissonTaille.Grande);
            Boisson article2 = new Boisson("fanta", BoissonTaille.Petite);
            Boisson article3 = new Boisson("eau", BoissonTaille.Moyenne);
            Gateau article4 = new Gateau("Lu", EGateau.Choco);
            Gateau article5 = new Gateau("geateau fraise", EGateau.Fraise);
            Gateau article6 = new Gateau("gateau vanille", EGateau.Vanille);
            facture.Ajouter(new Ligne(2, article1));
            facture.Ajouter(new Ligne(4, article2));
            facture.Ajouter(new Ligne(6, article3));
            facture.Ajouter(new Ligne(7, article4));
            facture.Ajouter(new Ligne(9, article5));
            facture.Ajouter(new Ligne(1, article1));

            Console.WriteLine(facture);

        }
    }
}
