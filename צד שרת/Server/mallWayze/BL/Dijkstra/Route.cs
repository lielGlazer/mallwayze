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
    //קשת 
    public class Route
    {
        //צומת אחת קוד
        public int  From { get; private set; }
        //צומת שניה קוד
        public int To { get; private set; }
        //מרחק בינהם
        public double Distance { get; private set; }

        public Route(int from, int to, double distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
    }
}
