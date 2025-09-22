using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceJacky" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceJacky.svc ou ServiceJacky.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceJacky : IServiceJacky
    {
        public string GetCoucou(string str)
        {
            return "coucou " + str;
        }
    }
}
