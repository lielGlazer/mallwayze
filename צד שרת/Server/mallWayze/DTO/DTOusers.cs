using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DTOUsers
    {
        
        public long UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DTOUsers()
        {
        }
        public DTOUsers(User l)
        {
            this.UserCode = l.UserCode;
            this.UserName = l.UserName;
            this.Password = l.Password;
            
        }
        public User ToTable(DTOUsers l)
        {
            User c = new User();
            c.UserCode = l.UserCode;
            c.UserName = l.UserName;
            c.Password = l.Password;
            return c;
        }
       
        public static List<DTOUsers> DTOlist(List<User> t)
        {
            List<DTOUsers> dtolist = new List<DTOUsers>();
            foreach (var c in t)
            {
                DTOUsers dto = new DTOUsers(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }
        


    }
}
