using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    class ManagerOpeningHours
    {
        static DBConection db = new DBConection();
        public static List<DTOOpeningHours> GetLocations()
        {
            List<OpeningHour> list = db.GetDbSet<OpeningHour>().ToList();
            List<DTOOpeningHours> dtoList = DTOOpeningHours.DTOlist(list);
            return dtoList;
        }
    }
}
