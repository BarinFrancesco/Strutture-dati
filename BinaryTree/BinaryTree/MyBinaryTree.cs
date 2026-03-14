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

                Queue<BinaryNode<T>> CodaNodi = new Queue<BinaryNode<T>>();
                CodaNodi.Enqueue(Root);

                while (CodaNodi.Count > 0)
                {
                    BinaryNode<T> current = CodaNodi.Dequeue();
                    if(current.LeftChild == null)
                    {
                        current.LeftChild = temp;
                        break;
                    }

                    CodaNodi.Enqueue(current.LeftChild);

                    if (current.RigthChild == null)
                    {
                        current.RigthChild = temp;
                        break;
                    }

                    CodaNodi.Enqueue(current.RigthChild);

                }

                return;
                
            }

        }

        
        public void Remove(BinaryNode<T> MovingNode) 
        {
             if(Root == null)
             {
                return;
             }
             BinaryNode<T> temp = Root;

            while(temp.LeftChild != null)
            {
                if (temp.RigthChild == null)
                {

                }
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
