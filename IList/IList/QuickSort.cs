using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList
{
    internal class QuickSort<T> : List<T> where T : IComparable
    {
        private int[] givenArray;

        private QuickSort(int[] array)
        {
            this.givenArray = array;
        }

        public int[] GetQuickSort(int[] givenArray, int first, int last)
        {
            if (first < last)
            {
                int auxiliar = Partition(givenArray, first, last);

                GetQuickSort(givenArray, first, (auxiliar - 1));

                GetQuickSort(givenArray, (auxiliar + 1), last);
            }

            return givenArray;
        }

        public int Partition(int[] givenArray, int firstIndex, int lastIndex)
        {
            int firstElement = givenArray[firstIndex];

            int i = firstIndex;

            int temp;

            for (int j = firstIndex + 1; j < lastIndex; j++)
            {
                if (givenArray[j] <= firstElement)
                {
                    i = i + 1;
                    temp = givenArray[j];

                    givenArray[j] = givenArray[i];

                    givenArray[i] = temp;
                }
            }

            temp = givenArray[firstIndex];

            givenArray[firstIndex] = givenArray[i];

            givenArray[i] = temp;

            return i;
        }
    }
}