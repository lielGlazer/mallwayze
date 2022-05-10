using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;


namespace API2.Controllers
{
    public class FavoriteStoresForTheUserController : ApiController
    {
        [Route("api/FavoriteStoresForTheUser/GetCaterory")]
        [HttpGet]
        //מחזיר את כל הרשימה
        public List<DTOFavoriteStoresForTheUser> GetCaterory()
        {
            List<DTOFavoriteStoresForTheUser> u = BL.ManagerFavoriteStoresForTheUser.GetFavoriteStoresForTheUser();
            return u;
        }
        //מחזיר רשימת חניות מודפות למשמתש
        public List<DTOStor> GetAllStor(DTOUsers user)
        {
            List<DTOStor> u = BL.ManagerFavoriteStoresForTheUserGetAllStorForUser(user);
            return u;
        }
    }
}
