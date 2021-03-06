using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using BL.BL;
using BL.Models;
using DTO;


namespace API3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FavoriteStoresForTheUserController : ApiController
    {   //מחזיר את כל הרשימה
        [Route("api/FavoriteStoresForTheUser/GetCaterory")]
        [HttpGet]
        //עובד
        public List<DTOFavoriteStoresForTheUser> GetCaterory()
        {
            return  BL.ManagerFavoriteStoresForTheUser.GetFavoriteStoresForTheUser();  
        }
        //מחזיר רשימת חניות מודפות למשמתש
        [Route("api/FavoriteStoresForTheUser/GetAllStorFavoraite")]
        [HttpPost] 
        //לא יודעת מה בדיוק מחזירים וזה לא עובד 
        public List<DTOStor> GetAllStorFavoraite([FromBody]UserInformation o)
        {
            return  BL.ManagerFavoriteStoresForTheUser.GetAllStorForUser(o.UserName,o.Password);  
        }


        [Route("api/FavoriteStoresForTheUser/all")]
        [HttpGet]
        //עובד
        public List<StoreWithLocation> all()
        {
            StorController stor = new StorController();
            List<StoreWithLocation> dTs = Dijkstra.MapSelectedStores(stor.GetSaleStor());
            return dTs;
            
        }


    }
}
