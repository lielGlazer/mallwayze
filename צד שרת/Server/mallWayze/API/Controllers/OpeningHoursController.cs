﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class OpeningHoursController : ApiController
    {
        // GET: api/OpeningHours
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OpeningHours/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OpeningHours
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OpeningHours/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OpeningHours/5
        public void Delete(int id)
        {
        }
    }
}
