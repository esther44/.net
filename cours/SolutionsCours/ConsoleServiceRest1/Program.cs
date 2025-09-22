using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsoleServiceRest1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelete();
        }

        static void TestGetAll()
        {
            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("api/personne", Method.Get);
            var queryResult = client.Execute<List<Personne>>(request).Data;

            foreach (Personne p in queryResult)
                Console.WriteLine(p);
        }

        static void TestGetById()
        {
            Console.WriteLine("id?");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("/api/personne/" + id, Method.Get);
            var queryResult = client.Execute<Personne>(request).Data;

            Console.WriteLine(queryResult);

        }

        static void TestPost()
        {
            Personne p = new Personne(24, "Kaelaenis", "Aerivaen");

            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("api/personne", Method.Post);
            request.AddJsonBody(p);

            var response = client.Execute<Personne>(request).Data;

            if (response != null)
            {
                Console.WriteLine(response);
            }
            else
            {
                Console.WriteLine("No response from server");
            }
        }

         static void TestDelete()
        {
            Console.WriteLine("id?");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("/api/personne/" + id, Method.Delete);
            var queryResult = client.Execute<string>(request).Content;

            Console.WriteLine(queryResult);

        }

        static void TestPut()
        {
            int id = 10;
            Personne p = new Personne(2, "aa", "SS");
            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("/api/personne/" + id, Method.Put);
            request.AddJsonBody(p);
            var queryResult = client.Execute<string>(request);
            Console.WriteLine(queryResult.Content);
            Console.WriteLine(queryResult.StatusCode);

            //var queryResult = client.Execute<string>(request).Data;
            //Console.WriteLine(queryResult);

        }

        static void TestPutValues()
        {

            int id = 200;

            var client = new RestClient("http://localhost:63830");
            var request = new RestRequest("/api/values/" + id, Method.Put);
            request.AddStringBody($"\"toto\"", DataFormat.Json);
            var queryResult = client.Execute<string>(request);
            Console.WriteLine(queryResult.Content);
            Console.WriteLine(queryResult.StatusCode);
        }

    }
}
