using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DTO;

namespace API2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StorController : ApiController
    {
        // הפונקציה מקבלת שמות של חנויות (רשימת שמות )ומחזירה רשימת מיקומים בהתאם
        //[Route("api/stor/ListLocationsForListStors/{}")]
        //[HttpPost]
        //public List<DTOLocations> ListLocationsForListStors(List<string> names)
        //{
        //    List<DTOLocations> loc = new List<DTOLocations>();
        //    foreach (var v in names)
        //    {
        //        loc.Add(GetLocationForStore(v));

        //    }
        //    return loc;
        //}

        // הפונקציה מקבלת שמות של חנויות(רשימת שמות)ומחזירה רשימת מיקומים בהתאם
        [Route("api/stor/CreateSelectedStoresMap")]
        [HttpPost]
        public List<DTOStor> CreateSelectedStoresMap(List<DTOStor> stores)
        {
            return BL.ManagerStor.CreatePath(stores);
        }



        //מחזיר מיקום על פי שם של חנות 
        [Route("api/stor/getLocationForStore/{name}")]
        [HttpGet]
        public DTOLocations GetLocationForStore(string name)
        {
            return BL.ManagerLocations.LocationForStor(name);
        }
        //מחזיר רשימה של חניות לפי קטגוריה מסויימת
        // GET: api/Stor
        [Route("api/stor/GetStoresByCategory/{category}")]
        [HttpGet]
        public List<DTOStor> GetStoresByCategory(string category)
        {
            return BL.ManagerCategoryForStor.GetAllStorOfXContaining(category);
        }


    }
}
