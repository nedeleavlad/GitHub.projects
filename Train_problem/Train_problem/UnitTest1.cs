using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Train_problem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BirdDistanceTest ()
        {
            Assert.AreEqual(25.5, CalculateDistanceBird(51));


        }

        double CalculateDistanceBird(double distance)
        {
            return distance / 2;


        }
    }
}
