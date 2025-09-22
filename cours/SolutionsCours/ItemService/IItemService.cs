using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Items;

namespace ItemService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IItemService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IItemService
    {
        [OperationContract]
        Item GetItemByparameter(double prix , string marque);

        [OperationContract]
        Item UpdateItem(Item value);

        [OperationContract]
        List<Item> GetListItem();
    }
}
