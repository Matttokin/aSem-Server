using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class getInfoRoleController : ApiController
    {
        // GET: api/getInfoRole
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/getInfoRole/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/getInfoRole
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/getInfoRole/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/getInfoRole/5
        public void Delete(int id)
        {
        }
    }
}
