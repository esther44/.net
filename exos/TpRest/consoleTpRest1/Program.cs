using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using TpRest1;

namespace consoleTpRest1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPost();
        }

        static void TestGetAll()
        {
            var client = new RestClient("http://localhost:63984");
            var request = new RestRequest("api/item", Method.Get);
            var queryResult = client.Execute<List<Item>>(request).Data;

            foreach (Item p in queryResult)
                Console.WriteLine(p);
        }

        static void TestGetById()
        {
            Console.WriteLine("ref?");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = new RestClient("http://localhost:63984");
            var request = new RestRequest("api/item/" + id, Method.Get);
            var queryResult = client.Execute<Item>(request).Data;

            var response = client.Execute(request);
            Console.WriteLine("Raw response: " + response.Content);

            if (queryResult != null)
            {
                Console.WriteLine(queryResult.ToString());
            }
            else
            {
                Console.WriteLine("Aucun article trouvé");
            }
        }

        static void TestPost()
        {
            Item i = new Item(5, "marque", 12.3);

            var client = new RestClient("http://localhost:63984");
            var request = new RestRequest("api/item", Method.Post);

            request.AddJsonBody(i);

            //var response = client.Execute(request);

            var response = client.Execute<Item>(request).Data;

            if (response != null)
            {
                Console.WriteLine(response);
            }
            else
            {
                Console.WriteLine("No response from server");
            }
        }

     
    }
}
