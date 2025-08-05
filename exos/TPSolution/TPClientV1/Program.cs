using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClientV1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test2()
        {
            Compte1 compte = new Compte1(1, 1, "BNP");
            Adresse adresse = new Adresse("ville", "rue", "France");
            Client client = new Client(compte, adresse, "Robert");
            client.Compte.Solde = 12;
            Console.WriteLine(client.Compte.Banque);
            client.Compte.Banque= "SG";
            Console.WriteLine(client);
        }

        static void Test()
        {
            Compte1 compte = new Compte1(1, 1, "BNP");
            Adresse adresse = new Adresse("ville", "rue", "France");
            Client client = new Client(compte, adresse, "Robert");
            Console.WriteLine(client);
        }
    }
}
