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
        [httpGet]
        public List<DTOStor> GetAllStor()
        {
            return BL.ManagerStor.GetStor();
        }
       
      

    }
}
