using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOWorkingDaysWeek
    {
        public long WorkingDayCode { get; set; }
        public string NameOfWorkDay { get; set; }
        public DTOWorkingDaysWeek()
        {
        }
        public DTOWorkingDaysWeek(WorkingDaysWeek l)
        {
            this.WorkingDayCode = l.WorkingDayCode;
            this.NameOfWorkDay =l.NameOfWorkDay;
          
        }
        public DTOWorkingDaysWeek(DTOWorkingDaysWeek l)
        {
            this.WorkingDayCode = l.WorkingDayCode;
            this.NameOfWorkDay = l.NameOfWorkDay;

        }
        public static List<DTOWorkingDaysWeek> DTOlist(List<WorkingDaysWeek> t)
        {
            List<DTOWorkingDaysWeek> dtolist = new List<DTOWorkingDaysWeek>();
            foreach (var c in t)
            {
                DTOWorkingDaysWeek dto = new DTOWorkingDaysWeek(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }

    }
}
