using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;


namespace API.Controllers
{
    public class mainController : ApiController
    {
        
        // GET: api/main
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/main/5
        public List<DTOcategory> GetCategory(int id) { return BL.cateroryManager.GetCategories();}

        // POST: api/main
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/main/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/main/5
        public void Delete(int id)
        {
        }
    }
}
