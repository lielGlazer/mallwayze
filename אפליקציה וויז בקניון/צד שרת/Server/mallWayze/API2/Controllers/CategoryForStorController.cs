using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;


namespace API2.Controllers
{
    public class CategoryForStorController : ApiController
    {   //ממחזיר את כל הקטגוריות לחנות
        [Route("api/CategoryForStor/GetCaterory")]
        [HttpGet]
        public List<DTOCategoryForStor> GetCaterory()
        {
            List<DTOCategoryForStor> u = BL.ManagerCategoryForStor.GetCategoryForStor();
            return u;
        }
        //מחזיר רשימה של חניות לפי קטגוריה מסויימת
        [Route("api/Stor/GetStoresByCategory/{category}")]
        [HttpGet]
        public List<DTOStor> GetStoresByCategory(string category)
        {
            return BL.ManagerCategoryForStor.GetAllStorOfXContaining(category);
        }

        //מחזיר רשימת של קטגוריות לחנות
        [Route("api/Stor/GetAllCategorysForStor/{stor}")]
        [HttpGet]
        public List<DTOCategory> GetAllCategorysForStor(string stor)
        {
            return BL.ManagerCategoryForStor.GetAllCtegoryForStor(stor);
        }
    }
}
