using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceRest1.Controllers
{
    public class TestController : ApiController
    {
        // GET api/values
        public List<string> Get()
        {
            List<string> list = new List<string>();
            list.Add("v1");
            list.Add("v2");
            return list;
        }

    }
}
