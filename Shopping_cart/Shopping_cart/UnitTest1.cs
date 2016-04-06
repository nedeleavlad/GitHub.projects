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
            Assert.AreEqual("Apple", GetTheCheapestProduct(product));
        }

        private string GetTheCheapestProduct(Product[] product)
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

        private static void RemoveASpecificElement(Product[] product, int index)
        {
            for (int i = index; i < product.Length - index; i++)
            {
                product[i].price = product[i + 1].price;
                product[i].name = product[i + 1].name;
            }
        }

        private static int GetPositionforTheMostExpensiveProduct(Product[] product)
        {
            int index = 0;
            double counter = 0;
            for (int i = 0; i < product.Length; i++)
            {
                if (counter < product[i].price)
                {
                    counter = product[i].price;
                    index = i;
                }
            }
            return index;
        }

        private Product[] RemoveMostExpensiveProduct(Product[] product)
        {
            int index = GetPositionforTheMostExpensiveProduct(product);
            RemoveASpecificElement(product, index);
            Array.Resize(ref product, product.Length - 1);
            return product;
        }

        [TestMethod]
        public void RemoveMostExpensiveElement()
        {
            var initial = new Product[] { new Product("Milk", 10), new Product("Sugar", 25), new Product("Tomatoes", 15) };
            var NeW = new Product[] { new Product("Milk", 10), new Product("Tomatoes", 15) };
            CollectionAssert.AreEqual(NeW, RemoveMostExpensiveProduct(initial));
        }
    }
}