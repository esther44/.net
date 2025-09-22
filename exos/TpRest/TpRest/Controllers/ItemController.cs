using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TpRest.Models;

namespace TpRest.Controllers
{
    public class ItemController : ApiController
    {
        private List<Item> GetItems()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item(12, "zz", 22));
            list.Add(new Item(13, "qq", 23));
            return list;
        }
        
        // GET api/item
        public List<Item> Get()
        {
            return GetItems();
        }
        
        // GET api/item/12
        public Item Get(int id)
        {
            return GetItems().Find(i => i.Ref == id);
        }

        public Item Post([FromBody] Item i)
        {
            i.Marque = i.Marque.ToUpper();
            i.Prix = i.Prix * 1.2;

            return i;
        }

        // PUT api/<controller>/5
        public string Put(int id, [FromBody]Item value)
        {
            return id + "   " + value;
        }

        // DELETE api/item/5
        public string Delete(int id)
        {
            return $"L'Item avec l'id {id} a été supprimé.";
        }



    }
}
