using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QSort()
        {
            int[] numbers = new int[] { 2, 4, 6, 5 };

            int[] output = new int[] { 2, 4, 5, 6 };

            CollectionAssert.AreEqual(output, QuickSort(numbers, 0, 4));
        }

        [TestMethod]
        public void QSort1()
        {
            int[] numbers = new int[] { 3, 22, 6, 10, 1 };

            int[] output = new int[] { 1, 3, 6, 10, 22 };

            CollectionAssert.AreEqual(output, QuickSort(numbers, 0, 5));
        }

        [TestMethod]
        public void QSort2()
        {
            int[] numbers = new int[] { 20, 44, 25, 102, 150, 123 };

            int[] output = new int[] { 20, 25, 44, 102, 123, 150 };

            CollectionAssert.AreEqual(output, QuickSort(numbers, 0, 6));
        }

        public int[] QuickSort(int[] givenArray, int first, int last)
        {
            if (first < last)
            {
                int auxiliar = Partition(givenArray, first, last);

                QuickSort(givenArray, first, (auxiliar - 1));

                QuickSort(givenArray, (auxiliar + 1), last);
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