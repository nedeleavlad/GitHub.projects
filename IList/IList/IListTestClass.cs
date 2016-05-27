using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IList
{
    [TestClass]
    public class IListTestClass
    {
        [TestMethod]
        public void IndexOf()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(1, list.IndexOf(2));
        }

        [TestMethod]
        public void InsertInListAnInt()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(2, 10);
            list.Insert(2, 10);
            list.Insert(2, 10);
            list.Insert(2, 10);
            Assert.AreEqual(7, list.Count);
        }

        [TestMethod]
        public void Add()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void RemovefromList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void ClearList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void CopyTo()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(1);
            var newList = new int[] { 1, 2, 3, 4, 5, 6 };
            list.CopyTo(newList, 3);
            int[] result = new int[] { 1, 2, 3, 3, 2, 1 };
            Assert.IsTrue(list.Compare(newList, result));
        }

        [TestMethod]
        public void ContainsListNumber()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            Assert.IsFalse(list.Contains(4));
            Assert.IsTrue(list.Contains(2));
        }
    }
}