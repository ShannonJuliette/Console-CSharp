using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class BST
    {

        public Node root;
        public int prime_count; //this class field has been created to be incremented accordingly during recursive calls

        public BST() { root = null; prime_count = 0; }

        //This method inserts nodes in the binary tree
        public Node insert(Node p)
        {
            Node temp = root;
            if (temp == null)
            {
                root = p;
                return root;
            }
            while (true)
            {
                if (p.num < temp.num)
                {
                    if (temp.left == null)
                    {
                        temp.left = p;
                        break;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = p;
                        break;
                    }
                    temp = temp.right;
                }
            }
            return (root);
        }//end of method

        //This method prints the nodes in the binary search tree in descending order
        //starting from the right subtree
        public void inDescOrder(Node p)
        {
            if (p == null) return;
            inDescOrder(p.right);
            Console.Write(p.num + " ");
            inDescOrder(p.left);
        }//end of method

        //This method returns the height of the binary search tree
        public int findHeight(Node p)
        {
            int left_count = 0;
            int right_count = 0;
            if (p == null) return 0;
            else
            {
                left_count = findHeight(p.left);
                right_count = findHeight(p.right);
            }
            if (right_count > left_count)
            {
                return right_count + 1;
            }
            else
            {
                return left_count + 1;
            }
        }//end of method

        //This method finds the total number of nodes in the binary tree
        public int findSize(Node p)
        {
            int right_count = 0;
            int left_count = 0;
            if (p == null) return 0;
            else
            {
                left_count = findSize(p.left);
                right_count = findSize(p.right);
            }
            int size = left_count + right_count + 1; // + 1 to include root
            return size;
        }//end of method

        //This method prints all the nodes level by level
        //The root is passed as parameter
        public void ByLevels(Node p)
        {
            SLL nodes = new SLL();
            if (p != null)
            {
                SLLNode pSLL = new SLLNode(p);
                pSLL.level = 0;
                nodes.AddToTail(pSLL); //adding the root
            }
            while (!nodes.isEmpty())
            {
                SLLNode qSLLNode = nodes.DeleteFromHead();
                int myCurrentLevel = qSLLNode.level;
                Console.Write(qSLLNode.pBSTNode.num + " " + "My level is: "+myCurrentLevel+"\r\n");
                if (qSLLNode.pBSTNode.left != null)
                {
                    SLLNode templeft = new SLLNode(qSLLNode.pBSTNode.left);
                    templeft.level = myCurrentLevel + 1;
                    nodes.AddToTail(templeft);
                }
                if (qSLLNode.pBSTNode.right != null)
                {
                    SLLNode tempright = new SLLNode(qSLLNode.pBSTNode.right);
                    tempright.level = myCurrentLevel + 1;
                    nodes.AddToTail(tempright);
                }
            }  
        }//end of method

        //This method recursively gets all the nodes in the binary search tree
        //stores them in a singly linked list then checks if they are prime, if so it prints them
        public void PrintPrimes(Node p)
        {
            SLL primes = new SLL();
            if (p == null) return;
            PrintPrimes(p.left);
            SLLNode temp = new SLLNode(p);
            primes.AddToTail(temp);
            PrintPrimes(p.right);
            SLLNode pointer = primes.head;
            while (pointer != null)
            {
                if(pointer.pBSTNode.isPrime(pointer.pBSTNode.num))
                {
                    Console.Write(pointer.pBSTNode.num + " ");
                    prime_count++;
                }
                pointer = pointer.next;
            }
        }//end of method



        ////This method counts the number of prime numbers
        //public int CountPrimes(Node p)
        //{
        //    int right_count = 0;
        //    int left_count = 0;
        //    if (p == null) { return 0; }
        //    else
        //    {
        //        if (p.left.isPrime(p.left.num)) { left_count = CountPrimes(p.left); }
        //        if (p.right.isPrime(p.right.num)) { right_count = CountPrimes(p.right); }
        //    }
        //    return left_count + right_count;
        //}//end method
    }
}

