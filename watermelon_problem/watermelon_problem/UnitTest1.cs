using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace watermelon_problem
{
    [TestClass]
    public class Watermelon
    {
        [TestMethod]
        public void watermelonDivideTest1()
        {
            Assert.AreEqual(1, divide_watermelon(4));


        }


        [TestMethod]
        public void watermelonDivideTest0()
        {
            Assert.AreEqual(0, divide_watermelon(3));


        }


        int divide_watermelon(int noKg)
        {
            if (noKg % 2 == 0) return 1;

            else return 0;

        }
    }
}
