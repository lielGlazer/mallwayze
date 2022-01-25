using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dijkstra
{
    public class Route
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public double Distance { get; private set; }

        public Route(string from, string to, double distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
    }
}
