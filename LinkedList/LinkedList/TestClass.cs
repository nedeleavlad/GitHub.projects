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
            LinkedList<int> List1 = new LinkedList<int>();
            List1.AddOnFirstPosition(2);
            List1.AddOnFirstPosition(3);
            List1.AddOnFirstPosition(4);
            List1.AddOnFirstPosition(10);
            Assert.IsTrue(List1.GetFirstElement().Equals(10));
        }

        [TestMethod]
        public void CleanList()
        {
            LinkedList<string> List2 = new LinkedList<string>();
            List2.AddOnFirstPosition("a");
            List2.AddOnFirstPosition("b");
            List2.AddOnFirstPosition("c");
            List2.AddOnFirstPosition("r");
            List2.Clean();
            Assert.AreEqual(0, List2.Count);
        }
    }
}