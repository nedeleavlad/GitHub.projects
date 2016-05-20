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

            int[] output = new int[] { 23, 5, 4, 1 };

            CollectionAssert.AreEqual(output, numbers.ShowBubbleSortMethod(new int[] { 23, 4, 5, 1 }));
        }
    }
}