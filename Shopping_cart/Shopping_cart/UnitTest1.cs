using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Shopping_cart
{
    public struct Product
    {
        public string name;

        public double price;

        public Product(string name, double price)

        {
            this.name = name;

            this.price = price;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CartSum()
        {
            var product = new Product[] { new Product("Milk", 20), new Product("Water", 15), new Product("Apple", 15) };
            Assert.AreEqual(50, GetSumOfPrices(product));
        }

        private double GetSumOfPrices(Product[] product)
        {
            double result = 0;
            for (int i = 0; i < product.Length; i++)
            {
                result += product[i].price;
            }
            return result;
        }

        [TestMethod]
        public void CheapestPrice()
        {
            var product = new Product[] { new Product("Apple", 10), new Product("Milk", 25), new Product("Tomatoes", 15) };
            Assert.AreEqual("Apple", GetTheCheaperProduct(product));
        }

        private string GetTheCheaperProduct(Product[] product)
        {
            string result = string.Empty;

            if (product.Length == 0) return "Array is empty";

            double counter = 0;

            for (int i = 0; i < product.Length - 1; i++)
            {
                counter = product[i].price;
                if (counter < product[i + 1].price)
                {
                    counter = product[i].price;
                    result = product[i].name;
                }
            }
            return result;
        }
    }
}