using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartOOP
{
    internal class Shopping_Cart
    {
        public Product[] products = new Product[0];

        public void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public int GetSumofProducts()
        {
            int sum = 0;
            foreach (var product in products)
            {
                sum = product.Sum(sum);
            }
            return sum;
        }

        public double CalculateTheAveragePrice()
        {
            return GetSumofProducts() / products.Length;
        }

        public Product GetCheapestProduct()
        {
            var index = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[index].ComparePrices(products[i]) == -1)
                    index = i;
            }
            return products[index];
        }

        public void RemoveSpecificPosition(int index)
        {
            for (int i = index; i < products.Length - 1; i++)
                products[i] = products[i + 1];
            Array.Resize(ref products, products.Length - 1);
        }

        public void RemoveMostExpensiveProduct()
        {
            int index = GetMostExpenive();
            RemoveSpecificPosition(index);
        }

        public int GetMostExpenive()
        {
            var index = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[index].ComparePrices(products[i]) == 1)
                    index = i;
            }
            return index;
        }
    }
}