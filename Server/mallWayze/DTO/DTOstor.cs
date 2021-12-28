using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOstor
    {


        public long CodeStor { get; set; }
        public long PlaceCode { get; set; }
        public string NameStor { get; set; }
        public System.TimeSpan OpeningHours { get; set; }
        public System.TimeSpan ClosingHours { get; set; }
        public bool Sale { get; set; }


    }
}

