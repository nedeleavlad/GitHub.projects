using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinkedList
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void FirstElement()
        {
            var List1 = new LinkedList<int>();
            List1.AddFirst(2);
            List1.AddFirst(3);
            List1.AddFirst(4);
            List1.AddFirst(10);
            Assert.IsTrue(List1.GetFirstElement().Equals(10));
        }

        [TestMethod]
        public void CleanList()
        {
            var List2 = new LinkedList<string>();
            List2.AddFirst("a");
            List2.AddFirst("b");
            List2.AddFirst("c");
            List2.AddFirst("r");
            List2.Clean();
            Assert.AreEqual(0, List2.Count);
        }

        [TestMethod]
        public void RemoveSpecificItem()
        {
            var list3 = new LinkedList<int>() { 1, 2, 3 };

            list3.Remove(1);
            Assert.AreEqual(new int[] { 2, 3 }, list3);
        }

        [TestMethod]
        public void RemoveLast()
        {
            var list = new LinkedList<int>() { 1, 2, 3 };
            list.RemoveLast();

            Assert.AreEqual(new int[] { 3, 2 }, list);
        }

        [TestMethod]
        public void RemoveFirst()
        {
            var list = new LinkedList<int>() { 1, 2, 3 };

            list.RemoveFirst();
            Assert.AreEqual(new int[] { 2, 3 }, list);
        }
    }
}