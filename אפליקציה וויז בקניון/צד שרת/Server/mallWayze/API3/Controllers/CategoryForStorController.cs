using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Web.Http.Cors;



namespace API3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CategoryForStorController : ApiController
    {
        //מקבל רשימה של קטגוריות ומחזיר רשימה של חנויות 
        [Route("api/CategoryForStor/GetStoresListByCategory/{category}")]
        [HttpGet]
        //עובד
        public List<DTOStor> GetStoresListByCategory(List<DTOCategory> categorylist)
        {
            return BL.ManagerCategoryForStor.listCategoeryOFstor(categorylist);
                
        }
        //ממחזיר את כל הקטגוריות לחנות
        [Route("api/CategoryForStor/GetCaterory")]
        [HttpGet]
        //עובד
        public List<DTOCategoryForStor> GetCaterory()
        {
            List<DTOCategoryForStor> u = BL.ManagerCategoryForStor.GetCategoryForStor();
            return u;
        }
        //מחזיר רשימה של חניות לפי קטגוריה מסויימת
        [Route("api/Stor/GetStoresByCategory/{category}")]
        [HttpGet]
        //עובד
        public List<DTOStor> GetStoresByCategory(string category)
        {
            return BL.ManagerCategoryForStor.GetAllStorOfXContaining(category);
        }
        //מחזיר רשימת של קטגוריות לחנות
        [Route("api/Stor/GetAllCategorysForStor/{stor}")]
        [HttpGet]
        //עובד
        public List<DTOCategory> GetAllCategorysForStor(string stor)
        {
            return BL.ManagerCategoryForStor.GetAllCtegoryForStor(stor);
        }
    }
}
