using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class dostavkaController : ApiController
    {
        // GET: api/dostavka
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/dostavka/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/dostavka
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/dostavka/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/dostavka/5
        public void Delete(int id)
        {
        }
    }
}
