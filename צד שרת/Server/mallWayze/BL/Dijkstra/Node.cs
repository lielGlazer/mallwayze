using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dijkstra
{
    class Node
    {
        //שם חנות
        public string Name { get; private set; }
        //המשקל של הצומת
        public double Value { get; set; }
        //צומת קודם
        public Node PreviousNode { get; set; }

        public Node(string name, double value = int.MaxValue, Node previousNode = null)
        {
            this.Name = name;
            this.Value = value;
            this.PreviousNode = previousNode;
        }
    }
}
