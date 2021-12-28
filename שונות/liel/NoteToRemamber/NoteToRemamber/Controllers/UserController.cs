using NoteToRemamber.Models;
using NoteToRemamber.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NoteToRemamber.Controllers
{
    public class UserController : ApiController
    {
        NoteRememberEntities db = new NoteRememberEntities();

        //public List<UserController> GetUsersfj() { }

        // GET: api/User/GetUser
        public List<userDTO> GetUser()
        {
            List<user> listuser =db.user.ToList();
            List<userDTO> dtolistuser=userDTO.todtoparsedtoinloop(listuser) ;
            return dtolistuser;
        }
     

        private void foraach(object i, List<userDTO> dtolistuser)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public string AddUser([FromBody]userDTO  userker)
        {
            user us = userker.tocomparfromdtotouserorginal();
            db.user.Add(us);
            db.SaveChanges();
            return "you add to list user success :)"+us.id+"this is yuor kod add  :)";
        }
        [HttpPost]
        public object login([FromBody]login log)
        {

            user listuser = db.user.Where(u => u.password == log.password).FirstOrDefault();
            if (listuser == null)
            {
                return new { seuceess = false };
            }
            else if (listuser.email != log.email)
            {
                return new { seuceess = false, UserDTO = new userDTO(listuser) };
            }
            else { 
                return new { seuceess = true, UserDTO = new userDTO(listuser) };
                 }
        }
            public bool UpdeteUoserDetaiys(int id, [FromBody]userDTO us)
        {
            user changeuser = db.user.FirstOrDefault(u => u.id==id );
            changeuser.id = us.id;
            changeuser.name = us.name;
            changeuser.last = us.last;
            changeuser.email = us.email;
            changeuser.password = us.password;
            db.SaveChanges();
            return true;

        }

        // DELETE: api/User/5
        public bool Delete(int kod)
        {

             user listuser = db.user.Where(u => u.id == kod).FirstOrDefault();
             List<note> noteremove = db.note.Where(t => t.userId== kod).ToList();
            foreach (var t in noteremove)
            {
                db.note.Remove(t); 

            }

            db.user.Remove(listuser);
            db.SaveChanges();
            return true; 

        }
    }
}
