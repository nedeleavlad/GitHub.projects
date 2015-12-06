using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capre
{
    [TestClass]
    public class KgFan
    {
        [TestMethod]
        public void numarkgfan()
        {
            Assert.AreEqual(20, cateKgFan(3, 5, 6, 7, 7));
        }

            int cateKgFan(int x,int y,int z,int w,int q)
        
                return (x*q*w)/(z*y);
    }
}
