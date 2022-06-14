using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DijkstraController : ApiController
    {


        //פונקציה ששולפת את כל הקטגוריות בקניון  
        [HttpPost]
        [Route("api/dijktra/GetDijktra")]
        //עובד
        public List<DTOStor> GetDijktra(List<DTOStor> S)
        {
            return BL.BL.Dijkstra.MapSelectedStores(S);

        }
    }
}

