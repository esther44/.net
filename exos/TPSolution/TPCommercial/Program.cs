using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Client c1 = new Client("CA", 200, Pole.Banque);
            Client c2 = new Client("SG", 300, Pole.Banque);

            Client c3 = new Client("Renault", 400, Pole.Auto);
            Client c4 = new Client("Peugeot", 500, Pole.Auto);

            List<Client> banqueList = new List<Client> { c1, c2 };
            List<Client> autoList = new List<Client> { c3, c4 };

            Commercial comm1 = new Commercial("1", "", "");
            Commercial comm2 = new Commercial("2", "nom", "prenom");

            Dictionary<Commercial, List<Client>> dico = new Dictionary<Commercial, List<Client>>();
            dico.Add(comm1, banqueList);
            dico.Add(comm2, autoList);

            Console.WriteLine("id de commercial : ");

            string saisie = Console.ReadLine();
            Commercial clefTrouvee = null;
            ICollection<Commercial> CommerciauxClef = dico.Keys;

            foreach (Commercial c in CommerciauxClef){
                if (c.Id == saisie)
                {
                    clefTrouvee = c;
                    break;
                }
            }
            if (clefTrouvee != null)
            {
                Console.WriteLine($"Clients de {clefTrouvee} :");
                foreach (Client client in dico[clefTrouvee])
                {
                    Console.WriteLine(client);
                }
            }
            else
            {
                Console.WriteLine("Aucun commercial trouvé avec cet ID.");
            }
        }
    }
}
