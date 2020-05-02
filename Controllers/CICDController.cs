using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GITLABCICD.Controllers
{
    public class CICDController : ApiController
    {
        // GET: api/CICD Test
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CICD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CICD
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CICD/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CICD/5
        public void Delete(int id)
        {
        }
    }
}
