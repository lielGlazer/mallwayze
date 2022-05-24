using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class WorkingDaysWeekController : ApiController
    {
        // GET: api/WorkingDaysWeek
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WorkingDaysWeek/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WorkingDaysWeek
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WorkingDaysWeek/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WorkingDaysWeek/5
        public void Delete(int id)
        {
        }
    }
}
