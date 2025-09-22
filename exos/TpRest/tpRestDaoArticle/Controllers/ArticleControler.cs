using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tpRestDaoArticle.Models;

namespace tpRestDaoArticle.Controllers
{
    public class ArticleController : ApiController
    {
        // GET api/article
        public List<Article> Get()
        {
            return new DaoArticle().SelectAll();
        }

        // GET api/article/5
        public Article Get(int id)
        {
            return new DaoArticle().SelectByRef(id);
        }

        // POST api/personne
        public void Post([FromBody]Article a)
        {
            new DaoArticle().Insert(a);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Article a)
        {
            new DaoArticle().Update(a);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            new DaoArticle().Delete(id);
        }
    }
}

