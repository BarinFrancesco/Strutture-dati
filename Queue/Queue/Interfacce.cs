using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public interface IQueue<T>
    {

        public bool IsEmpty();

        public void Enqueue(T e );

        public T Dequeue();

        public T Peek();

        public void Clear();

    }
}
