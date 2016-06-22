using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> headNode;

        private int count = 0;

        public LinkedList()
        {
            headNode = new Node<T>();
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public T GetFirstElement()
        {
            return headNode.next.value;
        }

        public void AddOnFirstPosition(T node)
        {
            Node<T> item = headNode;

            Node<T> newNode = new Node<T>(node);

            item = headNode.next;

            headNode.next = newNode;

            newNode.next = item;

            count++;
        }

        public void Clean()
        {
            headNode = null;
            count = 0;
        }

        public void Remove(T item)
        {
            Node<T> current = headNode;
            while (current.next != null)
            {
                if (current.next.value.Equals(item))
                {
                    current.next = current.next.next;
                    break;
                }
                else
                    current = current.next;
            }
        }

        public void RemoveLast()
        {
            Node<T> next = headNode;
            T value;
            if (next.next == null)
            {
                value = next.value;
                next = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var item = headNode.next;
            while (item != null)
            {
                yield return item.value;
                item = item.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}