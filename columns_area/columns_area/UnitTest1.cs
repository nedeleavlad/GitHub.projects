using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace columns_area
{
    [TestClass]
    public class RoomAreaTest
    {
        [TestMethod]
        public void AreaTest()
        {
            Assert.AreEqual(6, CalculateArea(0, 0, 3, 0, 0, 4));

        }

        float CalculateArea(int xa,int ya,int xb,int yb,int xc,int yc)
        {
            float ab = sqrt(pow((xb - xa), 2) + pow((yb - ya), 2));

            float bc = sqrt(pow((yc - yb), 2) + pow((xc - xb), 2));

            float ac = sqrt(pow((yc - ya), 2) + pow((xc - xa), 2));

            float p = (ab + ac + bc) / 2;

            return sqrt(p * (p - ab) * (p - ac) * (p - bc));


        }
    }
}
