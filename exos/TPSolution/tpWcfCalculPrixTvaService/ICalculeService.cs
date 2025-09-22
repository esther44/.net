using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using tpWcfCalculPrixTvaService.CalculeTVA;


namespace tpWcfCalculPrixTvaService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICalculeService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICalculeService
    {
        [OperationContract]
        double Calcule(int quantite, string article, double prix, TVAServiceETVA categorie);
    }
}
