using System;
using ShoppingSpree.Common;
namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.NullOrEmptyNameException);
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.NegativeMoneyException);
                }
                cost = value;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}


