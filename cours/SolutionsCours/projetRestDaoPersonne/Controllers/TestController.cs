using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace projetRestDaoPersonne.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string Test1()
        {
            return "Test1";
        }

        [HttpGet]
        // GET api/values/5
        public string Test2(int id)
        {
            return "Test2";
        }

        [HttpPost]
        // POST api/values
        public string Test3([FromBody]string value)
        {
            return "Test3";
        }

        [HttpPut]
        // PUT api/values/5
        public string Test4(int id, [FromBody]string value)
        {
            return "Test4";
        }

        [HttpDelete]
        public string Test5(int id)
        {
            return "Test5";
        }
    }
}
