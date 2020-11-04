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
            //else if(newNode.Value > rootNode.Value)
            //{
            //    rootNode.rightNode = ;
            //}
            //else if(newNode.Value <= rootNode.Value)
            //{
            //    rootNode.leftNode = newNode;
            //}
            else
            {
                Node focusNode = rootNode;
                while (true)
                {
                    if (newNode.Value > focusNode.Value)
                    {
                        if (focusNode.leftNode == null)
                        {
                            focusNode.leftNode = newNode;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }

                    else if (newNode.Value <= focusNode.Value)
                    {
                        if (focusNode.rightNode == null)
                        {
                            focusNode.rightNode = newNode;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.rightNode;
                        }
                        
                    }
                }
            }
        }
        public int Search(int input)
        {
            if (input == rootNode.Value)
            {
                Console.WriteLine("Value found");
                return rootNode.Value;
            }
            else
            {
                Node focusNode = rootNode;
                while (true)
                {
                    if (input > focusNode.Value)
                    {
                        if (focusNode.leftNode.Value == input)
                        {
                            Console.WriteLine("Value found");
                            return focusNode.leftNode.Value;
                        }
                        if (focusNode.leftNode == null)
                        {
                            Console.WriteLine("Sorry the value could not be found");
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }

                    else if (input <= focusNode.Value)
                    {
                        if (input == focusNode.rightNode.Value)
                        {
                            Console.WriteLine("Value found");
                            return focusNode.rightNode.Value;
                        }
                        if (focusNode.rightNode == null)
                        {
                            Console.WriteLine("Sorry the value could not be found");
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.rightNode;
                        }

                    }
                }
            }
        }


    }
    
}
