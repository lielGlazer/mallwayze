using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL
{
    public class ManagerUsers
    {
       
        
        static DBConection db = new DBConection();
        public static List<DTOUsers> GetUsers()
        {
            List<User> list = db.GetDbSet<User>().ToList();
            List<DTOUsers> dtoList = DTOUsers.DTOlist(list);
            return dtoList;
        }
        
        public static long RegisterUser(string nameU,string passU)
        {
            List<DTOUsers> userInDB = GetUsers();
            List<DTOUsers> us = userInDB.Where(s => s.UserName.Equals(nameU)).ToList();
            User u = new User();
            u.Password = passU;
            u.UserName = nameU;
            db.Execute<User>(u,DBConection.ExecuteActions.Insert);
            return u.UserCode;
        }
    }
}
