using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Voiture voiture = new Voiture("VW");
            Article article = new Article(1200);
            Client client = new Client("John");

            Generic<Voiture, Article, Client> generic = new Generic<Voiture, Article, Client>(voiture, article, client);

            Console.WriteLine(generic);

            string marque = generic.A.Marque;
            double prix = generic.B.Prix;
            string nom = generic.C.Nom;

            Console.WriteLine(marque);
            Console.WriteLine(prix);
            Console.WriteLine(nom);
        }

    }
}
