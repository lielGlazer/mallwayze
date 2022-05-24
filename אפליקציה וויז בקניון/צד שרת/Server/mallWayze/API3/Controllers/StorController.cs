using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL.BL;
using DTO;

namespace API3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StorController : ApiController
    {  
        //מחזיר חנות על פי קוד
        [Route("api/Stor/GetCategoryByID/{id}")]
        [HttpGet]
        public DTOStor GetStorByID(long id)
        {
            DTOStor dc = BL.ManagerStor.GetStor().FirstOrDefault(a => a.CodeStor == id);
            return dc;
        }
        //פונקציה שמחזירה רשימה של כל החניות בקניון
        [Route("api/Stor/GetAllStor")]
        
        public List<DTOStor> GetAllStor()
        {
            return BL.ManagerStor.GetStor();
        }
        //מחזירה רשימה של כל החניות בקנייון שיש להם מבצעים 
        [Route("api/Stor/GetSaleStor")]
        [HttpGet]
        public List<DTOStor> GetSaleStor()
        {
   //         Dijkstra dijkstra = MapSelectedStores( BL.ManagerStor.GetStorSale());
            return BL.ManagerStor.GetStorSale();
        }
    }
}
