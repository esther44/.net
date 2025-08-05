using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacade
{
    class Program
    {
        static void Main()
        {
            var facade = new Facade();

            facade.AjouterClient("Jacques Melloul", "jacques@example.com");
            facade.AjouterClient("Client Invalide", "email_sans_arobase");

            facade.PasserCommande("voiture");
            facade.PasserCommande("vélo");

        }
    }
}
