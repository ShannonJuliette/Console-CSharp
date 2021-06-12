using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Node
    {

        public Node left;
        public Node right;
        public int num;

        //The Node constructor initialises the values of the right and left pointers to null
        public Node(int num)
        {
            this.num = num;
            right = null;
            left = null;
        }

        //This method checks if a number is prime
        public Boolean isPrime(int n)
        {
            Boolean b = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }//end of method
    }
}
