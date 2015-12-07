using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Mp_Parchet
    {
        [TestMethod]
        public void TestParchet()
        {
            Assert.AreEqual(10, MpParchet(10, 34, 2, 4));

        }

           int MpParchet(int a,int b,int m,int n)
        {
            float p = (a * b) / (m * n);

            return p + 0.15 * p;

        }
    }
}
