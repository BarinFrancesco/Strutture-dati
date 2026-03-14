using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryNode<T>
    {

        public T Value { get; set; }

        public BinaryNode<T> LeftChild { get; set; }
        public BinaryNode<T> RigthChild { get; set; }
        

        public BinaryNode( T value )
        {
            Value = value;
            LeftChild = null;
            RigthChild = null;
        }
    }
}
