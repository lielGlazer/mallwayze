using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTOLocations
    {
       

        public long LocationCode { get; set; }
        public double AxisX { get; set; }
        public double AxisY { get; set; }
        public int  floor { get; set; }
        public DTOLocations()
        {

        }
        public DTOLocations(Locations l)
        {
            this.LocationCode = l.LocationCode;
            this.AxisX = (double)l.AxisX;
            this.AxisY = (double)l.AxisY;
            this.floor = (int)l.floor;
            
        }
        public DTOLocations(DTOLocations l)
        {
            this.LocationCode = l.LocationCode;
            this.AxisX = (double)l.AxisX;
            this.AxisY = (double)l.AxisY;
            this.floor = (int)l.floor;
        }
        public static List<DTOLocations> DTOlist(List<Locations> t)
        {
            List<DTOLocations> dtolist = new List<DTOLocations>();
            foreach(var c in t)
            {
                DTOLocations dto = new DTOLocations(c);
                dtolist.Add(dto);
            }
            return dtolist;
        }

    }
}
