using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShoppingCartOOP
{
    internal class Product
    {
        private string name;
        private int price;
        private int quantity;

        public Product(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public int Sum(int sum)
        {
            return sum = sum + this.price;
        }

        public int ComparePrices(Product Reference)
        {
            if (this.price < Reference.price)
                return 1;
            if (this.price > Reference.price)
                return -1;
            return 0;
        }

        public void IncreaseQuantity(int quantity)
        {
            this.quantity += quantity;
        }

        public void DecreaseQuantity(int quantity)
        {
            this.quantity -= quantity;
        }

        public int Total(int price, int quantity)
        {
            return this.quantity * this.price;
        }
    }
}