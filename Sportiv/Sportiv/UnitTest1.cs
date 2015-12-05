using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class NumberRepetitionsTest
    {
        [TestMethod]
        public void NumberRepetitions()
        {
            int number = CalculateRepetitions(3);

            Assert.AreEqual(9, number);
        }
         
        int CalculateRepetitions(int n)
        
            return (n(n+1)-n);
        
    }
}
