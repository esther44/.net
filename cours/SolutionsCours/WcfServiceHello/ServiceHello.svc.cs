using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceHello.OperationUpper;
namespace WcfServiceHello
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceHello" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceHello.svc ou ServiceHello.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceHello : IServiceHello
    {
        public string SayHello(string str)
        {
            ServiceUpperClient svc = new ServiceUpperClient();
            string reponse = svc.GetUpper("hello " + str);
            return reponse;
        }
    }
}
