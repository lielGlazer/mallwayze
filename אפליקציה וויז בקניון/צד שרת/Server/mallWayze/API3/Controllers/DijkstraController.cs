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

    


        [HttpPost]

        [Route("api/dijktra/GetDIJCategor")]
        //עובד
        public List<StoreWithLocation> GetDIJCategor(List<DTOCategory> categorylist)
        {

            List<DTOStor> storc = BL.ManagerCategoryForStor.listCategoeryOFstor(categorylist);
            return BL.BL.Dijkstra.pathOrginl(storc);

        }

        // מסלול קצר אמיתי 
        [HttpPost]
        [Route("api/dijktra/GetDijktra")]
        //עובד
        public List<StoreWithLocation> GetDijktra(List<DTOStor> S)
        {

            return BL.BL.Dijkstra.pathOrginl(S);

        }


        [HttpPost]
        [Route("api/dijktra/GetSaleDijktra")]
        //עובד מסלול לפי חניות במבצע 
        public List<StoreWithLocation> GetSaleDijktra(List<DTOStor> S)
        {
            return BL.BL.Dijkstra.pathSale(S);

        }

    }
}

