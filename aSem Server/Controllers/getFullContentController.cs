using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class getFullContentController : ApiController
    {
        // GET: api/getFullContent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/getFullContent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/getFullContent
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/getFullContent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/getFullContent/5
        public void Delete(int id)
        {
        }
    }
}
