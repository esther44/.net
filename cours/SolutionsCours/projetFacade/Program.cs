using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandeFacade commande = new CommandeFacade();
            commande.PasserCommande("Clavier mécanique");
        }
    }
}
