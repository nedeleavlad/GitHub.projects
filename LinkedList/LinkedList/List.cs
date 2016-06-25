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
        }

        public void RemoveLast()
        {
            Node<T> current = head;

            if ((current.next == null) || (current.next.next == null))
            {
                Clean();
            }

            while (current.next.next != null)
            {
                current = current.next.next;
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

                count--;
            }
        }

        public T GetLastElement()
        {
            Node<T> current = head;

            if (current.next == null) return head.value;
            if (current.next.next == null) return current.next.value;

            while (current.next.next != null)
            {
                current = current.next;
            }

            return current.next.value;
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