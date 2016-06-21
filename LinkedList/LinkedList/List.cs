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
        private Node<T> head;

        private int count = 0;

        public LinkedList()
        {
            head = new Node<T>();
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public T GetFirstElement()
        {
            return head.next.value;
        }

        public void AddOnFirstPosition(T node)
        {
            Node<T> item = head;

            Node<T> newNode = new Node<T>(node);

            item = head.next;

            head.next = newNode;

            newNode.next = item;

            count++;
        }

        public void Clean()
        {
            head = null;
            count = 0;
        }

        public void Remove(T item)
        {
            Node<T> current = head;
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

        public IEnumerator<T> GetEnumerator()
        {
            var item = head.next;
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