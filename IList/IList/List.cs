using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList
{
    internal class List<T> : IList<T>
    {
        private T[] array = new T[] { };
        private int index;

        public void Insert(int index, T item)
        {
            if (index < Count && index >= 0)
            {
                if (this.index <= array.Length)
                    Array.Resize(ref array, array.Length * 2);
                this.index++;
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
                return index;
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
                this.index--;
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
            if (array.Length <= Count && index == Count)
                Array.Resize(ref array, array.Length * 2);

            array[index] = item;
            index++;
        }

        public void Clear()
        {
            index = 0;
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public bool Remove(T item)
        {
            return true;
        }

        public void CopyTo(T[] givenArray, int index)
        {
            if (givenArray.Length <= array.Count())
                Array.Resize(ref givenArray, givenArray.Count() + array.Count() + 1);

            int j = index;
            for (int i = 0; i < this.index; i++)
            {
                givenArray.SetValue(array[i], j++);
            }
        }

        public bool Compare(T[] first, T[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (!first[i].Equals(second[i]))
                    return false;
            }
            return true;
        }

        public bool Contains(T item)
        {
            bool inList = false;
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item))
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int counter = 0;
            while (counter < Count)
            {
                yield return array[counter];
                counter++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            int counter = 0;
            while (counter < Count)
            {
                yield return array[counter];
                counter++;
            }
        }
    }
}