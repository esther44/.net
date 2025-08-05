using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFacade
{
    public class CommandeFacade
    {
        private StockService stock;
        private FacturationService facturation;
        private PaiementService paiement;
        private EmailService email;

        public CommandeFacade()
        {
            stock = new StockService();
            facturation = new FacturationService();
            paiement = new PaiementService();
            email = new EmailService();
        }

        public void PasserCommande(string produit)
        {
            Console.WriteLine("Traitement de la commande...\n");

            if (stock.VérifierStock(produit))
            {
                facturation.GénérerFacture(produit);
                paiement.EffectuerPaiement(produit);
                email.EnvoyerConfirmation(produit);
            }
            else
            {
                Console.WriteLine("Produit en rupture de stock.");
            }
        }
    }

}
