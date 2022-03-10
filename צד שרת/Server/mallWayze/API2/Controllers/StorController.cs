using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace API2.Controllers
{
    public class StorController : ApiController
    {
        // GET: api/Stor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //
        [Route("api/stor/getLocationForStore/{name}")]
       [HttpGet]
        public  DTOLocations GetLocationForStore(string name)
        {
          return  BL.ManagerLocations.LocationForStor(name);
        }

        // POST: api/Stor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Stor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stor/5
        public void Delete(int id)
        {
        }
    }
}
