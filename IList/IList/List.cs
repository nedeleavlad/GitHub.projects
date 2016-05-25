using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList
{
    internal class List<T> : IList<T>
    {
        private T[] array = new T[] { };
        private int _index;

        public List()
        {
            this.array = array;
        }

        public void Insert(int index, T item)
        {
            if (index < Count && index >= 0)
            {
                if (_index <= array.Length)
                    Array.Resize(ref array, array.Length * 2);
                _index++;
                for (int i = Count - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = item;
            }
        }

        public int Count
        {
            get
            {
                return _index;
            }
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                _index--;
            }
        }

        public int IndexOf(T item)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Add(T item)
        {
            if (Count == 0)
                Array.Resize(ref array, array.Length + 1);
            if (array.Length <= Count && _index == Count)
                Array.Resize(ref array, array.Length * 2);

            array[_index] = item;
            _index++;
        }

        public void Clear()
        {
            _index = 0;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return true;
        }
    }
}