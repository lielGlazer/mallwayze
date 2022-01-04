using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOStor
    {


        public long CodeStor { get; set; }
        public long PlaceCode { get; set; }
        public string NameStor { get; set; }
        public System.TimeSpan OpeningHours { get; set; }
        public System.TimeSpan ClosingHours { get; set; }
        public bool Sale { get; set; }
        public DTOStor()
        {

        }
        public DTOStor(Stor l)
        {
            this.CodeStor =(long)l.CodeStor;
            this.PlaceCode = (long)l.PlaceCode;
            this.NameStor = (string)l.NameStor;
            this.OpeningHours = (TimeSpan)l.OpeningHours;
            this.ClosingHours = (TimeSpan)l.ClosingHours;
            this.Sale = (bool)l.Sale;
           
        }
        public DTOStor(DTOStor l)
        {
            this.CodeStor = (long)l.CodeStor;
            this.PlaceCode = (long)l.PlaceCode;
            this.NameStor = (string)l.NameStor;
            this.OpeningHours = (TimeSpan)l.OpeningHours;
            this.ClosingHours = (TimeSpan)l.ClosingHours;
            this.Sale = (bool)l.Sale;
        }
        public static List<DTOStor> DTOlist(List<Stor> t)
        {
            List<DTOStor> dtolist = new List<DTOStor>();
            foreach (var c in t)
            {
                DTOStor dto = new DTOStor(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }


    }
}

