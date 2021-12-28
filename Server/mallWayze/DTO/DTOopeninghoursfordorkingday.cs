using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOopeninghoursfordorkingday
    {
        public long OpeningHoursCodeForWorkingDay { get; set; }
        public long StoreCode { get; set; }
        public long WorkingDayCode { get; set; }
        public long OpeningTimeCode1 { get; set; }
        public long OpeningTimeCode2 { get; set; }
        public DTOopeninghoursfordorkingday()
        {
                
        }

    }
}
