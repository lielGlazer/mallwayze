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

namespace API2.Controllers
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
            return BL.ManagerUsers.RegisterUser(o);

        }
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
