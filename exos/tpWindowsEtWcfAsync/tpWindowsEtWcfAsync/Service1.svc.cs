using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace tpWindowsEtWcfAsync
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public decimal GetPrixTotal(int quantite, decimal prix)
        {
            System.Threading.Thread.Sleep(5000);
            return quantite *prix;
        }

        public decimal GetPrixTotalHT(decimal prixTotalTTC)
        {
            return prixTotalTTC-= prixTotalTTC*20/100;
        }

    }
}
