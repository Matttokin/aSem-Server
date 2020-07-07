using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class infoDostupController : ApiController
    {
        // GET: api/infoDostup
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/infoDostup/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/infoDostup
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/infoDostup/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/infoDostup/5
        public void Delete(int id)
        {
        }
    }
}
