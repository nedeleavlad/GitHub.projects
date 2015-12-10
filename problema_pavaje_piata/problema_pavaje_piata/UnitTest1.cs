using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace problema_pavaje_piata
{
    [TestClass]
    public class Pavementt
    {
        [TestMethod]
        public void Pavement()
        {
            Assert.AreEqual(5,CalculateNrPavage(5, 4, 2));

        }

        int CalculateNrPavage(int m,int n,int a)
        {
            int p = (m * n) / (a * a); //bucati intregi

            return p;






        }
    }
}
