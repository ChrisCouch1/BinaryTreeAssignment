using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            Node node1 = new Node(50);
            Node node2 = new Node(49);
            Node node3 = new Node(51);
            Node node4 = new Node(48);
            Node node5 = new Node(52);
            Node node6 = new Node(47);
            Node node7 = new Node(53);
            Node node8 = new Node(46);
            Node node9 = new Node(54);
            binaryTree.Add(node1);
            binaryTree.Add(node2);
            binaryTree.Add(node3);
            binaryTree.Add(node4);
            binaryTree.Add(node5);
            binaryTree.Add(node6);
            binaryTree.Add(node7);
            binaryTree.Add(node8);
            binaryTree.Add(node9);
        }
    }
}
