//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OpeningHoursForDorkingDay
    {
        public long OpeningHoursCodeForWorkingDay { get; set; }
        public Nullable<long> StoreCode { get; set; }
        public Nullable<long> WorkingDayCode { get; set; }
        public Nullable<long> OpeningTimeCode1 { get; set; }
        public Nullable<long> OpeningTimeCode2 { get; set; }
    
        public virtual OpeningHours OpeningHours { get; set; }
        public virtual OpeningHours OpeningHours1 { get; set; }
        public virtual Stor Stor { get; set; }
        public virtual Stor Stor1 { get; set; }
        public virtual WorkingDaysWeek WorkingDaysWeek { get; set; }
    }
}
