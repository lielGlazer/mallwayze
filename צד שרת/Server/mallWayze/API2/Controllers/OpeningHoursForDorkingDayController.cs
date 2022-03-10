using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2.Controllers
{
    public class OpeningHoursForDorkingDayController : ApiController
    {
        // GET: api/OpeningHoursForDorkingDay
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OpeningHoursForDorkingDay/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OpeningHoursForDorkingDay
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OpeningHoursForDorkingDay/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OpeningHoursForDorkingDay/5
        public void Delete(int id)
        {
        }
    }
}
