using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinkedList
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList<int> List1 = new LinkedList<int>();
            List1.AddOnFirstPosition(2);
            List1.AddOnFirstPosition(3);
            List1.AddOnFirstPosition(4);
            List1.AddOnFirstPosition(10);
            Assert.IsTrue(List1.GetFirstElement().Equals(10));
        }
    }
}