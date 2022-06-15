using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StoreWithLocation
    {
        public string storeName { get; set; }
        public double xPoint { get; set; }
        public double yPoint { get; set; }

        public StoreWithLocation(string storeName, double xPoint, double yPoint)
        {
            this.storeName = storeName;
            this.xPoint = xPoint;
            this.yPoint = yPoint;
        }

        public StoreWithLocation()
        {
        }
    }
}
