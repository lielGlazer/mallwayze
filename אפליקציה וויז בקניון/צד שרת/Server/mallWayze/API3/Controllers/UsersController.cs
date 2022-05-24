using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.Models;
using BL;
using DTO;
using System.Web.Http.Cors;
using BL.BL;
using Newtonsoft.Json;
using System.Web;

namespace API3.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class UsersController : ApiController
    {
        [Route("api/Users/GetAllUser")]
        [HttpGet]
        public List<DTOUsers> GetAllUser()
        {
            List<DTOUsers> u = BL.ManagerUsers.GetUsers();
            return u;
        }

        //הוספת משתמש חדש למערכת 
        [Route("api/Users/Register")]
        [HttpPost]
        public DTOUsers Register([FromBody]DTOUsers o)
        {
            Console.WriteLine("safsd");
            return BL.ManagerUsers.RegisterUser(o);

        }

        //public DTOUsers Register()
        //{
        //    DTOUsers user = JsonConvert.DeserializeObject<DTOUsers>(HttpContext.Current.Request["user"]);
        //    return BL.ManagerUsers.RegisterUser(user);
        //    return BL.ManagerUsers.RegisterUser(o);

        //}
        //התחברות של המשתמש
        [Route("api/Users/Login")]
        [HttpPost]
        public DTOUsers Login([FromBody]UserInformation o)
        {
         
            return BL.ManagerUsers.LoginUser(o.UserName, o.Password);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
