using System;
using System.IO;

namespace Assignment_3
{
    class Program
    {
        //This method reads a textfile, stores the space-separated values in an array
        //loops through the array and creates a node that will then store the current element in the array
        //adds the node to binary search tree
        static BST readFile1()
        {
            BST bst1 = new BST();
            string[] A = File.ReadAllText(@"C:\Users\HP\Desktop\Data Structures Assignment\file1.txt").Split(" ");
            for (int i = 0; i < A.Length; i++)
            {
                Node p = new Node(Int32.Parse(A[i]));
                bst1.insert(p);
            }
            return bst1;
        }//end of method
        static BST readFile2()
        {
            BST bst2 = new BST();
            string[] A = File.ReadAllText(@"C:\Users\HP\Desktop\Data Structures Assignment\file2.txt").Split(" ");
            for (int i = 0; i < A.Length; i++)
            {
                Node p = new Node(Int32.Parse(A[i]));
                bst2.insert(p);
            }
            return bst2;
        }//end of method
        static BST readFile3()
        {
            BST bst3 = new BST();
            string[] A = File.ReadAllText(@"C:\Users\HP\Desktop\Data Structures Assignment\file3.txt").Split(" ");
            for (int i = 0; i < A.Length; i++)
            {
                Node p = new Node(Int32.Parse(A[i]));
                bst3.insert(p);
            }
            return bst3;
        }//end of method
        static void Main(string[] args)
        {
            BST bst1 = readFile1();
            BST bst2 = readFile2();
            BST bst3 = readFile3();

            //Printing size of tree
            int bst1size = bst1.findSize(bst1.root);
            int bst2size = bst2.findSize(bst2.root);
            int bst3size = bst3.findSize(bst3.root);
            Console.WriteLine("The size of binary search 1 is: " + bst1size);
            Console.WriteLine("The size of binary search 2 is: " + bst2size);
            Console.WriteLine("The size of binary search 3 is: " + bst3size);

            //Printing tree in descending order
            Console.WriteLine("\nPrinting binary search tree 1 in descending order:");
            bst1.inDescOrder(bst1.root);
            Console.WriteLine("\n\nPrinting binary search tree 2 in descending order:");
            bst2.inDescOrder(bst2.root);
            Console.WriteLine("\n\nPrinting binary search tree 3 in descending order:");
            bst3.inDescOrder(bst3.root);

            //Printing the height of each binary tree
            int bst1height = bst1.findHeight(bst1.root);
            int bst2height = bst2.findHeight(bst2.root);
            int bst3height = bst3.findHeight(bst3.root);
            Console.WriteLine("\n\nThe height of binary search 1 is: " + bst1height); 
            Console.WriteLine("The height of binary search 2 is: " + bst2height);
            Console.WriteLine("The height of binary search 3 is: " + bst3height);

            //Printing the numbers in the binary search tree "level by level"
            Console.WriteLine("\nPrinting the nodes in binary search tree 1 level by level: ");
            bst1.ByLevels(bst1.root);
            Console.WriteLine("\n\nPrinting the nodes in binary search tree 2 level by level: ");
            bst2.ByLevels(bst2.root);
            Console.WriteLine("\n\nPrinting the nodes in binary search tree 3 level by level: ");
            bst3.ByLevels(bst3.root);

            //Printing the number of prime numbers in the second binary search tree
            Console.WriteLine("\n\nPrinting the nodes that are prime in binary search tree 2: ");
            bst2.PrintPrimes(bst2.root);
            Console.WriteLine("\nThe number of prime numbers in binary tree 2: " + bst2.prime_count);
        }
    }
}
