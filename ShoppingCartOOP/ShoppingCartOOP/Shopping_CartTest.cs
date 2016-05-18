using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartOOP
{
    [TestClass]
    public class Shopping_Cartt
    {
        private Shopping_Cart shoppingCart;
        private Product[] products = new Product[0];

        [TestMethod]
        public void SumPrices()
        {
            shoppingCart = new Shopping_Cart(); ;
            Product a = new Product("appel", 4, 1);
            Product b = new Product("orange", 1, 1);
            Product c = new Product("sugar", 3, 1);
            shoppingCart.Add(new Product("appel", 4, 1));
            shoppingCart.Add(new Product("orange", 1, 1));
            shoppingCart.Add(new Product("sugar", 3, 1));
            Assert.AreEqual(8, shoppingCart.GetSumofProducts());
        }

        [TestMethod]
        public void RemoveElementPosX()
        {
            shoppingCart = new Shopping_Cart();
            shoppingCart.Add(new Product("appel", 4, 1));
            shoppingCart.Add(new Product("orange", 1, 1));
            shoppingCart.Add(new Product("sugar", 1, 1));
            shoppingCart.Add(new Product("abb", 5, 1));
            shoppingCart.RemoveSpecificPosition(1);
            Assert.AreEqual(10, shoppingCart.GetSumofProducts());
        }

        [TestMethod]
        public void MostExpensive()
        {
            shoppingCart = new Shopping_Cart();
            shoppingCart.Add(new Product("appel", 4, 1));
            shoppingCart.Add(new Product("orange", 1, 1));
            shoppingCart.Add(new Product("sugar", 7, 1));
            shoppingCart.Add(new Product("arrr", 5, 1));
            Assert.AreEqual(2, shoppingCart.GetMostExpenive());
        }
    }
}