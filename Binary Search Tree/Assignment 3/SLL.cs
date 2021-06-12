using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class SLL
    {

        public SLLNode head;
        public SLLNode tail;

        //The constructor initialises the head and tail to null
        public SLL()
        {
            head = null;
            tail = null;
        }

        //This method adds a singly linked list Node to the end of the singly linked list
        public void AddToTail(SLLNode p)
        {
            if (tail == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
            }
        }//end of method

        //This method deletes from the head of the singly linked list
        public SLLNode DeleteFromHead() 
        {
            SLLNode temp = null;
            if (head == null)
            {
                Console.WriteLine("List currently empty");
            }
            else
            {
                temp = head;
                head = head.next;
                if(head == null)
                {
                    tail = null;
                }
            }
            return temp;
        }//end of method

        //This method returns true if head is null
        public bool isEmpty()
        {
            return head == null;
        }//end of method
    }
}
