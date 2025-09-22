using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace projetRestDaoPersonne.Controllers
{
    public class ProductController : ApiController
    {
        static int[] tab = { 10, 20, 30, 40 };

        [HttpGet]
        [Route("api/products/list")]
        public IEnumerable<string> GetAllProducts()
        {
            return new string[] { "Laptop", "Phone", "Tablet" };
        }

        [HttpGet]
        [Route("api/products/details/{id:int}")]
        public string GetProductDetails(int id)
        {
            return $"Details of product {id}";
        }

        [HttpGet]
        [Route("api/products/search/{keyword}")]////api/products/search/zara
        public IEnumerable<string> Search(string keyword)
        {
            return new string[] { $"Result1 for {keyword}", $"Result2 for {keyword}" };
        }

        [HttpGet]
        [Route("api/products/search")]//api/products/search?keyword=toto
        public IEnumerable<string> Search2([FromUri] string keyword)
        {

            return new string[] { "Laptop1", "Phone", "Tablet" };
        }

        //GET /api/products/range/4/6 → paramètres dans l’URL(/)

        //GET /api/products/range? min = 4 & max = 6 → paramètres dans la query string (?)

        [HttpGet]
        [Route("api/products/filter/length")] //api/products/filter/length?min=5

        public IEnumerable<string> FilterByLength([FromUri] int min)
        {
            return new string[] { "Laptop2", "Phone", "Tablet" };
        }

        [HttpGet]
        [Route("api/products/range/{min:int}/{max:int}")]//api/products/filter/length?min=5&max=2
        public IEnumerable<string> GetByRange(int min, int max)
        {
            // Exemple : filtrer les produits par longueur du nom
            return new string[] { "Laptop3", "Phone", "Tablet" };
        }

        [HttpPost]
        [Route("api/products/add/")]  // api/products/add (dans le body)  10-->100
        public void Post([FromBody]int id)
        {
            tab[id] = 100;
        }

        [HttpGet]
        [Route("api/products/listtab")]
        public int[] GetAllProductsp()
        {
            return tab;
        }

    }
}
