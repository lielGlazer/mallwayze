using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Web.Routing;

namespace API.Controllers
{
    public class CategoryController : ApiController
    {   //פונקציה ששולפת את כל הקטגוריות בקניון 
        [Route("api/Category/GetCaterory")]
        [HttpGet]
        public List<DTOCategory> GetCaterory()
        {
            List<DTOCategory> u = BL.ManagerCaterory.GetCategories();
            return u;
        }
        //  מחזיר את הקטגוריה לפי המספר ID 
        [Route("api/GetCategoryByID/{id}")]
        [HttpGet]
        public DTOCategory GetCategoryByID(long id)
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
