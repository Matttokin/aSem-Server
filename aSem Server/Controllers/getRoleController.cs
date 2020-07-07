using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class getRoleController : ApiController
    {
        // GET: api/getRole
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/getRole/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/getRole
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/getRole/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/getRole/5
        public void Delete(int id)
        {
        }
    }
}
