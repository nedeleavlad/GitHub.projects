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
        private Product[] products = new Product[0];

        [TestMethod]
        public void TotalCosts()
        {
            Product pp = new Product("milk", 7, 2);
            Assert.AreEqual(14, pp.Total());
        }

        [TestMethod]
        public void Summ()
        {
            Product pp = new Product("milk", 5, 1);
            Product pp1 = new Product("bread", 6, 1);
            int a = 5;
            Assert.AreEqual(10, pp.Sum(a));
        }

        [TestMethod]
        public void DecreaseQuantity()
        {
            Product aa = new Product("milk", 5, 1);

            Assert.AreEqual(0, aa.DecreaseQuantity(1));
        }

        [TestMethod]
        public void IncreaseQuantity()
        {
            Product aa = new Product("milk", 5, 1);

            Assert.AreEqual(3, aa.IncreaseQuantity(2));
        }
    }
}