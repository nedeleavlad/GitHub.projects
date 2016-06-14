using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        public T value;

        public Node<T> next;

        public Node(T start)
        {
            value = start;

            next = null;
        }

        public Node()
        {
            value = default(T);
            next = null;
        }
    }
}