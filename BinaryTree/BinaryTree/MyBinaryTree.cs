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

        public void RemoveLast()
        {
            //se non c'è niente saltiamo, se c'è solo il root lo cancelliamo
            if (Root == null)
                return;

            if (Root.LeftChild == null && Root.RigthChild == null)
            {
                Root = null;
                return;
            }

            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();
            queue.Enqueue(Root);

            BinaryNode<T> current = null;
            BinaryNode<T> parent = null;

            while (queue.Count > 0)
            {
                current = queue.Dequeue();//di ogni ramo mettiamo in coda (se ci sono) il figlio sinistro e quello destro e salvo il padre
                                          //l'ultimo nodo sarà l'ultimo ad uscire dalla coda
                if (current.LeftChild != null)
                {
                    parent = current;
                    queue.Enqueue(current.LeftChild);
                }

                if (current.RigthChild != null)
                {
                    parent = current;
                    queue.Enqueue(current.RigthChild);
                }
            }

            // una volta usciti current è l'ultimo nodo visitato
            if (parent.RigthChild == current)
                parent.RigthChild = null;
            else
                parent.LeftChild = null;

        }


        public int numNodi()
        {
            return totNodi(Root);
        }

        private int totNodi(BinaryNode<T> nodo)
        {
            if(nodo == null)
            {
                return 0;
            }

            return 1 + totNodi(nodo.LeftChild) + totNodi(nodo.RigthChild);

        }

        public BinaryNode<T> Padre(BinaryNode<T> nodo)
        {
            if (Root == null)
                return null;

            return Controllanodi(Root, nodo);
        }

        private BinaryNode<T> Controllanodi(BinaryNode<T> currentnode, BinaryNode<T> SearchingNode)
        {
            if(currentnode == null)
            {
                return null;
            }

            if (currentnode.LeftChild == SearchingNode || currentnode.RigthChild == SearchingNode)
            {
                return currentnode;
            }

            // cerca nel sottoalbero sinistro
            BinaryNode<T> left = Controllanodi(currentnode.LeftChild, SearchingNode);
            if (left != null)
                return left;

            // cerca nel sottoalbero destro
            return Controllanodi(currentnode.RigthChild, SearchingNode);

        }

        public int Grado(BinaryNode<T> nodo)
        {
            int grado = 0;

            if (nodo.LeftChild != null)
                grado++;

            if (nodo.RigthChild != null)
                grado++;

            return grado;
        }

        public (BinaryNode<T> LeftChild, BinaryNode<T> RigthChild) Figli(BinaryNode<T> nodo)
        {
            if (nodo == null)
                return (null, null);

            return (nodo.LeftChild, nodo.RigthChild);
        }

        public BinaryNode<T> AggiungiNodo(BinaryNode<T> u, T value)
        {
            BinaryNode<T> nuovo = new BinaryNode<T>(value);

            if (u.LeftChild == null)
            {
                u.LeftChild = nuovo;
            }
            else if (u.RigthChild == null)
            {
                u.RigthChild = nuovo;
            }
            else
            {
                return null; // se il nodo ha già due figli non posso aggiungerlo
            }

            return nuovo;
        }

        public BinaryNode<T> AggiungiSottoalbero(MyBinaryTree<T> a, BinaryNode<T> u)
        {
            if (a == null || a.Root == null || u == null)//controllo degli errori
                return null;

            if (u.LeftChild == null)
            {
                u.LeftChild = a.Root;
            }
            else if (u.RigthChild == null)
            {
                u.RigthChild = a.Root;
            }
            else
            {
                return null; // se u ha già due figli non posso metterlo li
            }

            return a.Root;
        }

        public MyBinaryTree<T> rimuoviSottoalbero(BinaryNode<T> node)
        {
            if(node == null)
            {
                return null;
            }

            BinaryNode<T> Parent = Padre(node);

            MyBinaryTree<T> NuovoAlbero = new MyBinaryTree<T>();
            NuovoAlbero.Root = node;

            if (Parent == null) // se il padre non esise allora il nod è la radice
            {
                Root = null;
            } else 
            {
                if(Parent.LeftChild == node)
                {
                    Parent.LeftChild = null;
                } else
                {
                    Parent.RigthChild = null;
                }
            }

            return NuovoAlbero;
        }

        //metodo carino di stampa dell'albero
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
  
    }
}
