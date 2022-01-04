using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ManagerWorkingDaysWeek
    {
        static DBConection db = new DBConection();
        public static List<DTOWorkingDaysWeek> GetWorkingDaysWeek()
        {
            List<WorkingDaysWeek> list = db.GetDbSet<WorkingDaysWeek>().ToList();
            List<DTOWorkingDaysWeek> dtoList = DTOWorkingDaysWeek.DTOlist(list);
            return dtoList;
        }
    }
}
