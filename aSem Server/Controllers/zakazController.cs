using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class zakazController : ApiController
    {
        // GET: api/zakaz
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/zakaz/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/zakaz
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/zakaz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/zakaz/5
        public void Delete(int id)
        {
        }
    }
}
