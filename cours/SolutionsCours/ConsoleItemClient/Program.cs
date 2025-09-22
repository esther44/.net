using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItemClient.NSItem;
using Items;

namespace ConsoleItemClient
{
    class Program
    {
        static void Main(string[] args)
        {

            ItemServiceClient itemService = new ItemServiceClient();

            Item a = itemService.GetItemByparameter(100, "aa");
            Console.WriteLine(a);
            Item updated = itemService.UpdateItem(a);
            Console.WriteLine(updated);
            List<Item> items = itemService.GetListItem();
            Console.WriteLine(items);
        }
    }
}
