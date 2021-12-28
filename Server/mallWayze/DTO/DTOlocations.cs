using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTOlocations
    {
       

        public long LocationCode { get; set; }
        public double AxisX { get; set; }
        public double AxisY { get; set; }
        public int  floor { get; set; }
        public DTOlocations()
        {

        }

    }
}
