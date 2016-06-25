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
        }

        [TestMethod]
        public void RemoveLast()
        {
            var list = new LinkedList<int>() { 1, 2, 3 };
            list.RemoveLast();

            Assert.AreEqual(2, list.GetLastElement());
        }

        [TestMethod]
        public void RemoveLastOneElement()
        {
            var list = new LinkedList<int> { 1 };
            list.RemoveLast();

            Assert.AreEqual(-1, list.Count);
        }

        [TestMethod]
        public void RemoveFirst3ElementsList()
        {
            var list = new LinkedList<int>() { 1, 2, 3 };

            list.RemoveFirst();
            Assert.AreEqual(2, list.GetFirstElement());
        }

        [TestMethod]
        public void RemoveFirstOneElement()
        {
            var list = new LinkedList<int> { 1 };
            list.RemoveFirst();

            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void LastElementOneElement()
        {
            var list = new LinkedList<int> { 1 };

            Assert.AreEqual(1, list.GetLastElement());
        }

        [TestMethod]
        public void LastElementMoreElements()
        {
            var list = new LinkedList<int> { 1, 2, 3 };

            Assert.AreEqual(1, list.GetLastElement());
        }
    }
}