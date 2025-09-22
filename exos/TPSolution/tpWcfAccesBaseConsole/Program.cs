using System;
using System.Collections.Generic;
using tpWcfAccesBaseConsole.NS1; // espace du proxy WCF

namespace tpWcfAccesBaseConsole
{
    class Program
    {
        // Client WCF
        static AccesBaseServiceClient client = new AccesBaseServiceClient();

        static void Main(string[] args)
        {
            // Insert un nouvel article
            InsertArticle(101, "Samsung", 350);

            // Affiche tous les articles
            AfficherTousLesArticles();

            // Affiche un article par ID
            AfficherArticleParId(101);

            client.Close();

            Console.WriteLine("\nTerminé. Appuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
        static void InsertArticle(int refArticle, string marque, int prix)
        {
            var article = new Article
            {
                Ref = refArticle,
                Marque = marque,
                Prix = prix
            };

            client.Insert(article);
            Console.WriteLine($"Article {refArticle} inséré avec succès.");
        }

        static void AfficherTousLesArticles()
        {
            List<NS1.Article> articles = client.SelectAll();
            Console.WriteLine("\nListe des articles :");
            foreach (var art in articles)
            {
                Console.WriteLine($"{art.Ref} - {art.Marque} - {art.Prix}€");
            }
        }

        static void AfficherArticleParId(int refArticle)
        {
            var article = client.SelectById(refArticle);
            if (article != null)
            {
                Console.WriteLine($"\nArticle trouvé : {article.Ref} - {article.Marque} - {article.Prix}€");
            }
            else
            {
                Console.WriteLine($"\nAucun article trouvé avec ID {refArticle}");
            }
        }
    }
}
