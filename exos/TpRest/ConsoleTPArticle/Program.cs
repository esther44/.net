using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsoleTPArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelete();
        }

        static void TestGetAll()
        {
            var client = new RestClient("http://localhost:50056");
            var request = new RestRequest("api/article", Method.Get);
            var queryResult = client.Execute<List<Article>>(request).Data;

            if (queryResult != null)
            {
                foreach (Article a in queryResult)
                    Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Aucun article trouvé.");
            }
        }

        static void TestGetById()
        {
            Console.WriteLine("Référence ?");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = new RestClient("http://localhost:50056");
            var request = new RestRequest("/api/article/" + id, Method.Get);
            var queryResult = client.Execute<Article>(request).Data;

            if (queryResult != null)
            {
                Console.WriteLine(queryResult);
            }
            else
            {
                Console.WriteLine("Article introuvable.");
            }
        }

        static void TestPost()
        {
            Console.Write("Ref ? ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marque ? ");
            string marque = Console.ReadLine();
            Console.Write("Prix ? ");
            double prix = Convert.ToDouble(Console.ReadLine());

            Article a = new Article(id, marque, prix);

            var client = new RestClient("http://localhost:50056");
            var request = new RestRequest("api/article", Method.Post);
            request.AddJsonBody(a);

            var response = client.Execute<Article>(request).Data;

            if (response != null)
            {
                Console.WriteLine("Article ajouté : " + response);
            }
            else
            {
                Console.WriteLine("Erreur : pas de réponse du serveur");
            }
        }

        static void TestDelete()
        {
            Console.WriteLine("Id ?");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = new RestClient("http://localhost:50056");
            var request = new RestRequest("/api/article/" + id, Method.Delete);
            var queryResult = client.Execute<string>(request).Content;

            Console.WriteLine(queryResult);
        }

        static void TestPut()
        {
            Console.WriteLine("Id de l’article à modifier ?");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nouvelle marque ? ");
            string marque = Console.ReadLine();
            Console.Write("Nouveau prix ? ");
            double prix = Convert.ToDouble(Console.ReadLine());

            Article a = new Article(id, marque, prix);

            var client = new RestClient("http://localhost:50056");
            var request = new RestRequest("/api/article/" + id, Method.Put);
            request.AddJsonBody(a);

            var queryResult = client.Execute<string>(request);
            Console.WriteLine(queryResult.Content);
            Console.WriteLine(queryResult.StatusCode);
        }

    }
}
