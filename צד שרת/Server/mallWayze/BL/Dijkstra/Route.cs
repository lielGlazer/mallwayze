using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL;

namespace BL.Dijkstra
{
    //המסלול שמובנה מלוקשיין 
    public class Route
    {
        public DTOLocations From { get; private set; }
        public DTOLocations To { get; private set; }
        public double Distance { get; private set; }

        public Route(DTOLocations from, DTOLocations to, double distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
    }
}
