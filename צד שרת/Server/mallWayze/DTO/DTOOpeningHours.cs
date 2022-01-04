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
        public System.TimeSpan OpeningHours { get; set; }
        public string ClosingTime { get; set; }
        public DTOOpeningHours()
        {

        }
        public DTOOpeningHours(OpeningHours l)
        {
            this.OpeningTimeCode = l.OpeningTimeCode;
            this.OpeningHours = (System.TimeSpan)l.OpeningHours1;
            this.ClosingTime = l.ClosingTime;
          

        }
        public DTOOpeningHours(DTOOpeningHours l)
        {
            this.OpeningTimeCode = l.OpeningTimeCode;
            this.OpeningHours = (TimeSpan)l.OpeningHours;
            this.ClosingTime = l.ClosingTime;
        }
        public static List<DTOOpeningHours> DTOlist(List<OpeningHours> t)
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
