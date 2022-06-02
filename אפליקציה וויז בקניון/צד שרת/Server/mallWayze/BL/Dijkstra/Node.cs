using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL.BL
{
    public class Node
    {
        //שם חנות
        public DTOStor Store { get; private set; } //החנות בעצמה

        //המשקל של הצומת
        public double Value { get; set; }//(המשקל של הצומת (מה היה המרחק הכי קצר עד לצומת הנוכחית 
        //צומת קודם
        public Node PreviousNode { get; set; }//(הצומת הקודמת (שעל ידה נדע מהו המסלול הקצר ביותר בסוף האלגוריתם 
        //פעולה בונה צומת
        public Node(DTOStor store, double value, Node previousNode )
        {
            this.Store = store;
            this.Value = value;
            this.PreviousNode = previousNode;
        }
        public Node(DTOStor store) { this.Store = store; }

        public override bool Equals(object obj)
        {
            Node n = (Node)obj;
            return Store.CodeStor ==n.Store.CodeStor;
        }
    }
}
