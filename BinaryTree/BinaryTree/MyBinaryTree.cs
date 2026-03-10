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

        public void PrintDebug()
        {
            PrintDebug(Root, 0);
        }

        private void PrintDebug(BinaryNode<T> node, int level)
        {
            if (node == null)
                return;

            PrintDebug(node.RigthChild, level + 1);

            Console.WriteLine(new string(' ', level * 4) + node.Value);

            PrintDebug(node.LeftChild, level + 1);
        }
        //funzioen per la stampa 
        /*
         * insert
         * */
    }
}
