using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMyDataStructures
{
    public class Nodo<T>
    {

        public T Data { get; set; }

        public Nodo<T> Next {get; set;}

        public Nodo(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
