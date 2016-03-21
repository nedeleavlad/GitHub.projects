using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cyclist
{
    [TestClass]
    public class UnitTest1
    {
        public struct Cyclist
        {
            public string name;
            public int[] records;
            public int diameter;

            public Cyclist(string name, int[] records, int diameter)
            {
                this.name = name;
                this.records = records;
                this.diameter = diameter;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}