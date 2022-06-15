using DTO;
using BL;
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
    //[Route("api/location")]
    public class LocationsController : ApiController
    {   //צריך לעבוד על זה כי זה לא ממש עובד
        //יהנו מסלול הפונקציה מקבלת שמות של חנויות(רשימת שמות)ומחזירה רשימת מיקומים בהתאם
        [Route("api/Locations/CreateSelectedStoresMap")]
        [HttpPost]
        public List<StoreWithLocation> CreateSelectedStoresMap(List<DTOStor> stores)
        {
            return BL.ManagerStor.CreatePath(stores);
        }
        //מחזיר מיקום על פי שם של חנות 
        [Route("api/Locations/GetLocationForStore/{name}")]
        [HttpGet]
        //עובד
        public DTOLocations GetLocationForStore(string name)
        {
            return BL.ManagerLocations.LocationForStor(name);
        }
    }
}
