using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tpRestDaoArticle.Models;

namespace tpRestDaoArticle.Controllers
{
    public class CompteController : ApiController
    {

        private static List<Compte> comptes = new List<Compte>
        {
            new Compte("FR001", "BNP", 1200),
            new Compte("FR002", "Société Générale", 2500),
            new Compte("FR003", "Crédit Agricole", 500),
        };

        [HttpGet]
        [Route("api/compte/list")]
        public IEnumerable<Compte> GetAllComptes()
        {
            return comptes;
        }

        [HttpGet]
        [Route("api/compte/liste/{index:int}")] ///api/compte/liste/1
        public IHttpActionResult GetCompteByIndex(int index)
        {
            if (index < 0 || index >= comptes.Count)
                return NotFound();
            return Ok(comptes[index]);
        }

        // GET api/compte/search/FR002
        [HttpGet]
        [Route("api/compte/search/{rib}")]
        public IHttpActionResult GetCompteByRib(string rib)
        {
            Compte compte = comptes.Find(c => c.Rib == rib);
            if (compte == null) return NotFound();
            return Ok(compte);
        }

        // POST api/compte/list/add
        [HttpPost]
        [Route("api/compte/list/add")]
        public IHttpActionResult AddCompte([FromBody] Compte nouveauCompte)
        {
            if (nouveauCompte == null)
                return BadRequest("Compte invalide");

            comptes.Add(nouveauCompte);
            return Ok(comptes);
        }

        // GET api/compte/liste/count
        [HttpGet]
        [Route("api/compte/liste/count")]
        public int GetComptesCount()
        {
            return comptes.Count;
        }

        // GET api/compte/liste/range?min=1000&max=3000
        [HttpGet]
        [Route("api/compte/liste/range")]
        public IEnumerable<Compte> GetComptesBySoldeRange([FromUri] double min, [FromUri] double max)
        {
            return comptes.Where(c => c.Solde >= min && c.Solde <= max).ToList();
        }
    }
}
