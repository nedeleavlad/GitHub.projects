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

        public void Add(T data)
        {
            AddFirst(data);
        }

        public T GetFirstElement()
        {
            return head.next.value;
        }

        public void AddFirst(T node)
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

        public void RemoveLast()
        {
            Node<T> current = head;

            if (head.next == null) return;

            while (current.next.next != null)
            {
                current = current.next.next;

                current.next.next = null;
            }

            current.next = null;
            count--;
        }

        public void RemoveFirst()
        {
            if ((head.next == null) || (head.next.next == null)) Clean();
            else
            {
                head.next = head.next.next;
            }

            count--;
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