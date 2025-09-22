using projetRestDaoPersonne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace projetRestDaoPersonne.Controllers
{
    public class PersonneController : ApiController
    {

        // GET api/<controller> selectAll
        public List<Personne> Get()
        {
            return new DaoPersonne().SelectAll(); ;
        }

        // GET api/<controller>/5 selectById
        public Personne Get(int id)
        {
            return new DaoPersonne().SelectById(id);
        }

        // POST api/personne
        public void Post([FromBody]Personne p)
        {
            new DaoPersonne().Insert(p);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Personne p)
        {
            new DaoPersonne().Update(p);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            new DaoPersonne().Delete(id);
        }
    }
}
