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

        public static DTOUsers LoginUser(string nameU, string passU)
        {
            List<DTOUsers> userInDB = GetUsers();
            DTOUsers us = userInDB.FirstOrDefault(s => s.UserName.Equals(nameU));
            if (us == null)
                return null;
            else if (us.Password != passU)
                return null;
            return us;

        }
        public static DTOUsers RegisterUser(DTOUsers u)
        {
            DBConection db = new DBConection();
            User newLogin = u.ToTable();
            db.Execute<User>(newLogin, DBConection.ExecuteActions.Insert);
            u.UserCode = newLogin.UserCode;
            return u;
        }
    }
}
