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
            int[] numbers = new int[] { 2, 3, 56, 43, 87, 69 };

            int[] output = new int[] { 2, 3, 43, 56, 69, 87 };

            CollectionAssert.AreEqual(output, numbers.);
        }
    }
}