using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartOOP
{
    [TestClass]
    public class Productt
    {
        [TestMethod]
        public void TotalCosts()
        {
            Product pp = new Product("milk", 7, 2);
            Assert.AreEqual(14, pp.Total(7, 2));
        }

        [TestMethod]
        public void Summ()
        {
            Product pp = new Product("milk", 5, 1);
            Product pp1 = new Product("bread", 6, 1);
            int a = 5;
            Assert.AreEqual(10, pp.Sum(a));
        }
    }
}