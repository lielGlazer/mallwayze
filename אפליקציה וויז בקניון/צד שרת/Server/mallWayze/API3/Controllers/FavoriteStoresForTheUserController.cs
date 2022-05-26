using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using BL.Models;
using DTO;


namespace API3.Controllers
{
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
        
    }
}
