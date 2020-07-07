using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class typeDostController : ApiController
    {
        // GET: api/typeDost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/typeDost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/typeDost
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/typeDost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/typeDost/5
        public void Delete(int id)
        {
        }
    }
}
