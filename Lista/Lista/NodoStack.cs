using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Nodo<T>
    {
        public T Data { get; private set; }
        public Nodo<T> Previous { get; set; }

        public Nodo(T value) 
        {
            Data = value;
            Previous = null;
        }
    }
}
