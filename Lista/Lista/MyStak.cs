using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class MyStak<T>
    {

        public Nodo<T> Top { get; private set; }

        public MyStak()
        {
            Top = null;
        }

        public bool isEmpty()
        {
            return Top == null ? true: false;
        }

        public void push(T nuovo)
        {
            Nodo<T> Temp = new Nodo<T>(nuovo);
            if(Top == null) 
            {
                Top = Temp;
            }else
            {
                Temp.Previous = Top;
                Top = Temp;
            }
            
        }


        public T pop() 
        { 
            if(Top == null)
            {
                throw new Exception("Pila già vuota");
            }

            Nodo<T> ret = Top;
            
            
            Top = Top.Previous;

            return ret.Data;

        }

        public T peek()
        {
            if (Top == null)
            {
                throw new Exception("Pila vuota, nessun elemento da ritornare");
            }

            return Top.Data;
        }

        public void clear()
        {
            Top = null;
        }
        
    }
}
