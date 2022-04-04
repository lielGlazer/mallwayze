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
        public DTOUsers(Users l)
        {
            this.UserCode = l.UserCode;
            this.UserName = l.UserName;
            this.Password = l.Password;
            
        }
        public Users ToTable(DTOUsers l)
        {
            Users c = new Users();
            c.UserCode = l.UserCode;
            c.UserName = l.UserName;
            c.Password = l.Password;
            return c;
        }
       
        public static List<DTOUsers> DTOlist(List<Users> t)
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
