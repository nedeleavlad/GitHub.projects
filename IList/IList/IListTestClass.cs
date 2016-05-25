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
    }
}