using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;


namespace API.Controllers
{
    public class CategoryController : ApiController
    {
        //api/Category/GetCaterory
        public List<DTOCategory> GetCaterory()
        {
            List<DTOCategory> u = BL.ManagerCaterory.GetCategories();
            return u;
        }

        // GET: api/Category


        // GET: api/Category/5
        public DTOCategory Get(long id)
        {
            DTOCategory dc = BL.ManagerCaterory.GetCategories().FirstOrDefault(a=>a.CategoryCode==id);
            return dc;
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
