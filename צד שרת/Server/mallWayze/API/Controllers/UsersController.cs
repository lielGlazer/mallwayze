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

namespace API.Controllers
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
        // GET: api/Users

        // GET: api/Users/5
        public string GetAllUser(int id)
        {
            return "value";
        }

        // POST: api/Users
        [Route("api/Users/Register")]
        [HttpPost]
        public DTOUsers Register(DTOUsers o)
        {
            return BL.ManagerUsers.RegisterUser(o);

        }
        [Route("api/Users/Login")]
        [HttpPost]
        public DTOUsers Login([FromBody]UserInformation o)
        {
            return BL.ManagerUsers.LoginUser(o.UserName, o.UserPassword);
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
