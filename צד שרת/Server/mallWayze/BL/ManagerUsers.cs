using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ManagerUsers
    {
        static DBConection db = new DBConection();
        public static List<DTOUsers> GetLocations()
        {
            List<Users> list = db.GetDbSet<Users>().ToList();
            List<DTOUsers> dtoList = DTOUsers.DTOlist(list);
            return dtoList;
        }
    }
}
