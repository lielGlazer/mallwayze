using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTOopeninghours
    {
      

        public long OpeningTimeCode { get; set; }
        public System.TimeSpan OpeningHours { get; set; }
        public string ClosingTime { get; set; }
        public DTOopeninghours()
        {

        }

    }
}
