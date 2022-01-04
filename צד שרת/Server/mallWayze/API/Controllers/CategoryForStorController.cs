using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CategoryForStorController : ApiController
    {
        public List<DTOCategory> GetCaterory()
        {
            List<DTOCategory> u = BL.ManagerCaterory.GetCategories();
            return u;
        }

        // GET: api/Category


        // GET: api/Category/5
        public DTOCategory Get(long id)
        {
            DTOCategory dc = BL.ManagerCaterory.GetCategories().FirstOrDefault(a => a.CategoryCode == id);
            return dc;
        }

        // GET: api/CategoryForStor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CategoryForStor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategoryForStor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategoryForStor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategoryForStor/5
        public void Delete(int id)
        {
        }
    }
}
