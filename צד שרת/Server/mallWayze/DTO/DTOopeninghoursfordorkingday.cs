﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOOpeningHoursForDorkingDay
    {
        public long OpeningHoursCodeForWorkingDay { get; set; }
        public long StoreCode { get; set; }
        public long WorkingDayCode { get; set; }
        public long OpeningTimeCode1 { get; set; }
        public long OpeningTimeCode2 { get; set; }
        public DTOOpeningHoursForDorkingDay()
        {
                
        }
        public DTOOpeningHoursForDorkingDay(OpeningHoursForDorkingDay l)
        {
            this.OpeningHoursCodeForWorkingDay = l.OpeningHoursCodeForWorkingDay;
            this.StoreCode = (long)l.StoreCode;
            this.WorkingDayCode = (long)l.WorkingDayCode;
            this.OpeningTimeCode1 = (long)l.OpeningTimeCode1;
            this.OpeningTimeCode2 = (long)l.OpeningTimeCode2;

        }
        public DTOOpeningHoursForDorkingDay(DTOOpeningHoursForDorkingDay l)
        {
            this.OpeningHoursCodeForWorkingDay = l.OpeningHoursCodeForWorkingDay;
            this.StoreCode = (long)l.StoreCode;
            this.WorkingDayCode = (long)l.WorkingDayCode;
            this.OpeningTimeCode1 = (long)l.OpeningTimeCode1;
            this.OpeningTimeCode2 = (long)l.OpeningTimeCode2;
        }
        public static List<DTOOpeningHoursForDorkingDay> DTOlist(List<OpeningHoursForDorkingDay> t)
        {
            List<DTOOpeningHoursForDorkingDay> dtolist = new List<DTOOpeningHoursForDorkingDay>();
            foreach (var c in t)
            {
                DTOOpeningHoursForDorkingDay dto = new DTOOpeningHoursForDorkingDay(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }


    }
}
