using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceRest1.Models;
namespace ServiceRest1.Controllers
{
    public class PersonneController : ApiController
    {
        // GET api/<controller>
        public List<Personne> Get()
        {
            List<Personne> personnes = new List<Personne>();
            personnes.Add(new Personne(1, "Kaelaenis", "Aerivaen"));
            personnes.Add(new Personne(2, "Doe", "John"));
            return personnes;
        }

        // GET api/<controller>/5
        public Personne Get(int id)
        {
            return new Personne(id, "Kaelaenis", "Aerivaen");
        }

        public Personne Post([FromBody] Personne p)
        {
            p.Nom = p.Nom.ToUpper();
            p.Prenom = p.Prenom.ToLower();

            return p;
        }

        // PUT api/<controller>/5
        public string Put(int id, [FromBody]Personne value)
        {
            return id + "   " + value;
        }

        // DELETE api/<controller>/5
        public string Delete(int id)
        {
 
                return $"La personne avec l'id {id} a été supprimée.";
          
        }


    }
}
