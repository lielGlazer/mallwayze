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
        //public DTOOpeningHours(OpeningHour l)
        //{
        //    this.OpeningTimeCode = l.OpeningTimeCode;
        //    this.OpeningHours =(DateTime) l.OpeningHours;
        //    this.ClosingTime = (DateTime)l.ClosingTime;
          

        //}
        public OpeningHours ToTable(DTOOpeningHours l)
        {
            OpeningHours c = new OpeningHours();
            c.OpeningTimeCode = l.OpeningTimeCode;
            c.OpeningHours1 = l.OpeningHours;
            c.ClosingTime = l.ClosingTime;
            return c;
        }
       
        public static List<DTOOpeningHours> DTOlist(List<OpeningHours> t)
        {
            List<DTOOpeningHours> dtolist = new List<DTOOpeningHours>();
            //foreach (var c in t)
            //{
            //    DTOOpeningHours dto = new DTOOpeningHours(c);
            //    dtolist.Add(dto);
            //}
            return dtolist;
        }


    }
}
