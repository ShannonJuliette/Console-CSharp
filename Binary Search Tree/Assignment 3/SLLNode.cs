using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class SLLNode
    {
        public SLLNode next;
        public Node pBSTNode;
        public int level;

        //The SLLNode constructor initialises the value of the next pointer to null
        public SLLNode(Node p)
        {
            pBSTNode = p;
            next = null;
        }
    }
}
