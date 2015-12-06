using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ciuperci
{
    [TestClass]
    public class CiuperciRosii
    {
        [TestMethod]
        public void numarCiuperciRosii()
        {
            Assert.AreEqual(2, ciuperci_rosii(10, 3));

        }

        int ciuperci_rosii(int n,int x)
            return ((x*n)/(x+1));
    }
}
