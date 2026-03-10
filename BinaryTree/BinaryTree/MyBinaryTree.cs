using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class MyBinaryTree<T>
    {

        BinaryNode<T> Root { get; set; }

        public MyBinaryTree()
        {
            Root = null;
        }

        public void Insert( T Value)
        {
            BinaryNode<T> temp = new BinaryNode<T>(Value);

            if(Root == null) 
            {
                Root = temp;
            }else
            {

                (BinaryNode<T> node, bool direction) Lastnode = Getlastnode(Root);

                if (Lastnode.direction)
                {
                    Lastnode.node.LeftChild = temp;
                } else
                {
                    Lastnode.node.RigthChild = temp;
                }
                
            }

        }

        public (BinaryNode<T> node, bool direction) Getlastnode(BinaryNode<T> MovingNode) 
        {
             
            if (MovingNode.LeftChild == null)
            {
                return (MovingNode, true);
            }
            else if (MovingNode.RigthChild == null)
            {
                return (MovingNode, false);
            }
            else //if (MovingNode.RigthChild == null && MovingNode.LeftChild == null)
            {
                return Getlastnode(MovingNode.LeftChild);

            }
        }

        public void PrintTree()
        {
            PrintTree(Root);
        }

        private void PrintTree(BinaryNode<T> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Value);

            PrintTree(node.LeftChild);
            PrintTree(node.RigthChild);
        }
        //funzioen per la stampa 
        /*
         * insert
         * */
    }
}
