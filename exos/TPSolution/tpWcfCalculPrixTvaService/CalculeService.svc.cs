using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using tpWcfCalculPrixTvaService.CalculeTVA;

namespace tpWcfCalculPrixTvaService { 


    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CalculeService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CalculeService.svc ou CalculeService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CalculeService : ICalculeService
    {
        public double Calcule(int quantite, string article, double prix, TVAServiceETVA categorie)
        {
        TVAServiceClient client = new TVAServiceClient();

            try
            {
                double prixTotal = quantite * prix;

                // Calcul de la TVA pour cet article
                return client.CalculTVA(prixTotal, categorie);
            }
            finally
            {
                if (client.State == System.ServiceModel.CommunicationState.Faulted)
                    client.Abort();
                else
                    client.Close();
            }
        }
    }
}
