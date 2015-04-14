using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySPA.Controllers
{
    public class FakeController : ApiController
    {
        // GET: api/Fake
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fake/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fake
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fake/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fake/5
        public void Delete(int id)
        {
        }
    }
}
