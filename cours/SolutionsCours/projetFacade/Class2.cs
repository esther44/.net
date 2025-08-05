using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFacade
{
    public class StockService
    {
        public bool VérifierStock(string produit)
        {
            Console.WriteLine("Vérification du stock pour : " + produit);
            return true;
        }
    }

    public class FacturationService
    {
        public void GénérerFacture(string produit)
        {
            Console.WriteLine("Facture générée pour "+ produit);
        }
    }

    public class PaiementService
    {
        public void EffectuerPaiement(string produit)
        {
            Console.WriteLine("Paiement effectué pour : " + produit);
        }
    }

    public class EmailService
    {
        public void EnvoyerConfirmation(string produit)
        {
            Console.WriteLine("E-mail de confirmation envoyé pour : " + produit);
        }
    }
}
