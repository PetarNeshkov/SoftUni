﻿
namespace Restaurant
{
    public class Product
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}