using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Items;

namespace ItemService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ItemService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ItemService.svc ou ItemService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ItemService : IItemService
    {
        public Item GetItemByparameter(double prix, string marque)
        {
            return new Item(prix, marque);
           
        }

        public Item UpdateItem(Item value)
        {
            value.Prix += value.Prix * 20 / 100;
            return value;
        }

        public List<Item> GetListItem()
        {
            List<Item> liste = new List<Item>();

            liste.Add(new Item( 10, "aa"));
            liste.Add(new Item(20, "dd"));
            liste.Add(new Item(30, "ff"));

            return liste;
        }
    }
}
