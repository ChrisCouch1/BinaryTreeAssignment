using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node rootNode;

        public BinaryTree()
        {
            rootNode = null;
        }

        public void Add(Node newNode)
        {
            if(rootNode == null)
            {
                rootNode = newNode;
            }
            else if(newNode.Value > rootNode.Value)
            {
                rootNode.rightNode = newNode;
            }
            else if(newNode.Value <= rootNode.Value)
            {
                rootNode.leftNode = newNode;
            }
        }
    }
}
