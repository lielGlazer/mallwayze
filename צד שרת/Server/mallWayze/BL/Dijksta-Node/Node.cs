﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dijksta_Node
{
    class Node
    {
        public string Name { get;private set; }
        public double Value { get; set; }
        public Node PreviousNode { get; set; }
        public Node(string name, double value = int.MaxValue, Node previousNode = null)
        {
            this.Name = name;
            this.Value = value;
            this.PreviousNode = previousNode;
        }
    }
}
    
