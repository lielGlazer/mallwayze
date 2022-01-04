using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    class ManagerOpeningHoursForDorkingDay
    {
        static DBConection db = new DBConection();
        public static List<DTOOpeningHoursForDorkingDay> GetOpeningHoursForDorkingDay()
        {
            List<OpeningHoursForDorkingDay> list = db.GetDbSet<OpeningHoursForDorkingDay>().ToList();
            List<DTOOpeningHoursForDorkingDay> dtoList = DTOOpeningHoursForDorkingDay.DTOlist(list);
            return dtoList;
        }

    }
}
