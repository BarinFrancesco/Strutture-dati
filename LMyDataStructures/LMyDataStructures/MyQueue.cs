using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LMyDataStructures
{
    public class MyQueue<T> : IQueue<T>
    {

        public Nodo<T> Head { get; set; }

        public MyQueue()
        {
            Head = null;
        }


        public bool IsEmpty()
        {
            return Head == null ? true : false; 
        }

        public void Enqueue(T e)
        {
            Nodo<T> nuovo = new Nodo<T>(e);
            if(Head == null)
            {
                Head = nuovo;
            }
            else
            {
                Nodo<T> temp  = Head;

                while ( temp.Next != null )
                {
                    temp = temp.Next;
                }

                temp.Next = nuovo;
            }
        }

        public T Dequeue()
        {
            Nodo<T> temp = Head;

            Head = Head.Next;

            return temp.Data;
        }

        public T Peek()
        {
            if(Head == null)
            {
                throw new ArgumentNullException("La lista è vuota");
            }
            return Head.Data;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}
