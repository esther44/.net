using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicePersonne.Model;

namespace WcfServicePersonne
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Personne GetPersonne();

        [OperationContract]
        Personne Update(Personne p);

        [OperationContract]
        Personne GetPersonneParam(string nom, string prenom, int age);

        [OperationContract]
        List<Personne> GetListPersonne();




        // TODO: ajoutez vos opérations de service ici
    }
}
