using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL;

namespace BL.BL
{
    //קשת 
    public class Route
    {
        //צומת אחת קוד
        public Node  From { get;  set; }
        //צומת שניה קוד
        public Node To { get;  set; }
        //מרחק בינהם
        public double Distance { get;  set; }

        public Route(Node from, Node to, double distance)
        {
            this.From = from;
            this.To = to;
            this.Distance = distance;
        }
    }
}
