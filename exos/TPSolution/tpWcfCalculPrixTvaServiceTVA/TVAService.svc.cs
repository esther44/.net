using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace tpWcfCalculPrixTvaServiceTVA
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "TVAService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez TVAService.svc ou TVAService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class TVAService : ITVAService
    {
        public double CalculTVA(double prixTTC, ETVA cat)
        {
            double taux = cat.GetTaux();
            double prixHT = prixTTC / (1 + taux / 100);
            return prixTTC - prixHT; 
        }

        public enum ETVA
        {
            Normal = 2000,
            Restau = 1000,
            Epicerie = 550,
            Medoc = 210
        }

    }
    public static class TVAExtensions
    {
        public static double GetTaux(this TVAService.ETVA tva)
        {
            return (double)tva / 100;
        }
    }
}
