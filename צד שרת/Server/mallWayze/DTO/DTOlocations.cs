﻿using DAL;
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
        public DTOLocations(Location l)
        {
            this.LocationCode = l.LocationCode;
            this.AxisX = (double)l.AxisX;
            this.AxisY = (double)l.AxisY;
            this.floor = (int)l.floor;
            
        }
        public Location ToTable(DTOLocations l)
        {
            Location c = new Location();
            c.LocationCode = l.LocationCode;
            c.AxisX = l.AxisX;
            c.AxisY = l.AxisY;
            c.floor = l.floor;
            return c;
        }
      
        public static List<DTOLocations> DTOlist(List<Location> t)
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
