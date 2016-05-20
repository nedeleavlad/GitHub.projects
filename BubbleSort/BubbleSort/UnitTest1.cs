using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BubbleSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSort()
        {
            BubbleSort numbers = new BubbleSort(new int[] { 23, 4, 5, 1 });

            int[] output = new int[] { 1, 4, 5, 23 };

            CollectionAssert.AreEqual(output, numbers.ShowBubbleSortMethod(new int[] { 23, 4, 5, 1 }));
        }
    }
}