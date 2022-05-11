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
            return  BL.ManagerFavoriteStoresForTheUser.GetFavoriteStoresForTheUser();  
        }
        //מחזיר רשימת חניות מודפות למשמתש
        [Route("api/FavoriteStoresForTheUser/GetAllStor/{}")]
        [HttpGet]
        public List<DTOStor> GetAllStor(DTOUsers user)
        {
            return  BL.ManagerFavoriteStoresForTheUser.GetAllStorForUser(user);  
        }
        
    }
}
