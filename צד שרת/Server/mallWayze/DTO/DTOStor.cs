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
        public bool Sale { get; set; }
        public  DTOLocations Locations { get; set; }
        public DTOStor()
        {

        }
        public DTOStor(Stor l)
        {
            this.CodeStor =(long)l.CodeStor;
            this.PlaceCode = (long)l.PlaceCode;
            this.NameStor = (string)l.NameStor;
            this.Sale = (bool)l.Sale;
            this.Locations =new DTOLocations( l.Locations);
        }
        public Stor ToTable(DTOStor l)
        {
            Stor c = new Stor();
            c.CodeStor = l.CodeStor;
            c.PlaceCode = l.PlaceCode;
            c.NameStor = l.NameStor;
            c.Sale = l.Sale;
            return c;
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

