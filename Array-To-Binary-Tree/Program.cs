using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_To_Binary_Tree
{
    class Program
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root;

            public void PrintTreeInOrder(Node root)
            {
                if (root != null)
                {
                    PrintTreeInOrder(root.Left);
                    Console.WriteLine(root.Data);
                    PrintTreeInOrder(root.Right);
                }
            }

            public void PrintTreePreOrder(Node root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.Data);
                    PrintTreePreOrder(root.Left);
                    PrintTreePreOrder(root.Right);
                }
            }

            public void PrintTreePostOrder(Node root)
            {
                if (root != null)
                {
                    PrintTreePostOrder(root.Left);
                    PrintTreePostOrder(root.Right);
                    Console.WriteLine(root.Data);
                }
            }
        }

        public static Node InsertInOrder(int[] arr, Node root, int i)
        {
            if (i < arr.Length)
            {
                Node tempNode = new Node(arr[i]);
                root = tempNode;
                root.Left = InsertInOrder(arr, root.Left, i * 2 + 1);
                root.Right = InsertInOrder(arr, root.Right, i * 2 + 2);
            }
            return root;
        }

        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            bt.Root = InsertInOrder(arr, bt.Root, 0);
            Console.WriteLine("In order traverse tree is:");
            bt.PrintTreeInOrder(bt.Root);
            Console.WriteLine("Pre order traverse tree is:");
            bt.PrintTreePreOrder(bt.Root);
            Console.WriteLine("Post order traverse tree is:");
            bt.PrintTreePostOrder(bt.Root);
        }
    }
}
