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
            Assert.AreEqual("Yes, the watermelon can be divided", divide_watermelon(4));


        }


        [TestMethod]
        public void watermelonDivideTest0()
        {
            Assert.AreEqual("The watermelon cannot be divided", divide_watermelon(3));


        }


        [TestMethod]
        public void watermelonDivideTest2()
        {
            Assert.AreEqual("The watermelon cannot be divided", divide_watermelon(2));


        }


        string divide_watermelon(int noKg)
        {
            if ((noKg % 2 == 0) && (noKg!=2)) return "Yes, the watermelon can be divided";

            else return "The watermelon cannot be divided";

        }
    }
}
