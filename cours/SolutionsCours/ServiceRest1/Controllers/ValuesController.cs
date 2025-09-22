using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceRest1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value : "+id;
        }

        // POST api/values
        //public string Post()
        public string Post([FromBody]string value)
        {
            return "post ok"+ value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "put ok"+id+" "+value;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "delete id:" + id;
        }
    }
}
