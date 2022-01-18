using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.Models;
using BL;
using DTO;
namespace API.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
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
