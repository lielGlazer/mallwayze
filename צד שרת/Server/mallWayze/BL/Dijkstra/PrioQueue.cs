﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Dijkstra
{//תור עדיפות
    class PrioQueue : LinkedList<Node>//יורש מרישמה מרשימה מקושרת 
    {
        public void AddNodeWithPriority(Node node)
        {
            if (this.Count == 0)
            {
                this.AddFirst(node);
            }
            else
            {
                if (node.Value >= this.Last.Value.Value)
                {
                    this.AddLast(node);
                }
                else           
                {
                    for (LinkedListNode<Node> it = this.First; it != null; it = it.Next)
                    {
                        if (node.Value <= it.Value.Value)
                        {
                            this.AddBefore(it, node);
                            break;
                        }
                    }
                }
            }
        }

        public bool HasLetter(Node n)
        {
            for (LinkedListNode<Node> it = this.First; it != null; it = it.Next)
            {
                if (it.Value == n) { return true; }
            }
            return false;
        }
    }
}
