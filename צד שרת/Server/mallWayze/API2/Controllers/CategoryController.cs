using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Web.Routing;
using System.Web.Http.Cors;


namespace API2.Controllers
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
        [Route("api/Category/GetCategoryByID/{id}")]
        [HttpGet]
        public DTOCategory GetCategoryByID(long id)
        {
            DTOCategory dc = BL.ManagerCaterory.GetCategories().FirstOrDefault(a=>a.CategoryCode==id);
            return dc;
        }

    }
}
