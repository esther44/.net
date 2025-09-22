using Employes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEmploye
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "SrvEmploye" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez SrvEmploye.svc ou SrvEmploye.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class SrvEmploye : ISrvEmploye
    {
        public Employe GetEmploye()
        {
            return new Employe("Dupond", "TT");
        }
    }
}
