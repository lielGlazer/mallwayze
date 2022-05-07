using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL.Dijkstra
{
    public class Node
    {
        //שם חנות
        public DTOStor Store { get; private set; } //שם החנות

        //המשקל של הצומת
        public double Value { get; set; }
        //צומת קודם
        public Node PreviousNode { get; set; }

        public Node(DTOStor store, double value = int.MaxValue, Node previousNode = null)
        {
            this.Store = store;
            this.Value = value;
            this.PreviousNode = previousNode;
        }
    }
}
