using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOOpeningHours
    {
      

        public long OpeningTimeCode { get; set; }
        public DateTime OpeningHours { get; set; }
        public DateTime ClosingTime { get; set; }
        public DTOOpeningHours()
        {

        }
        public DTOOpeningHours(OpeningHour l)
        {
            this.OpeningTimeCode = l.OpeningTimeCode;
            this.OpeningHours =(DateTime) l.OpeningHours;
            this.ClosingTime = (DateTime)l.ClosingTime;
          

        }
        public OpeningHour ToTable(DTOOpeningHours l)
        {
            OpeningHour c = new OpeningHour();
            c.OpeningTimeCode = l.OpeningTimeCode;
            c.OpeningHours = l.OpeningHours;
            c.ClosingTime = l.ClosingTime;
            return c;
        }
       
        public static List<DTOOpeningHours> DTOlist(List<OpeningHour> t)
        {
            List<DTOOpeningHours> dtolist = new List<DTOOpeningHours>();
            foreach (var c in t)
            {
                DTOOpeningHours dto = new DTOOpeningHours(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }


    }
}
