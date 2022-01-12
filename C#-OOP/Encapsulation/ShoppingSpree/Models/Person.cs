using System;
using System.Collections.Generic;
using ShoppingSpree.Common;

namespace ShoppingSpree.Models
{
   public class Person
    {
        private const string CannotAffordProductException = "{0} can't afford {1}";
        private const string SuccessfullyBoughtProduct = "{0} bought {1}";

        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;
        //ICollection-използваме го за да вадим много разл списъци в класа
        //readolnly-не позволява един път сетнато да се променя повече

        private Person()
        {
            bag = new List<Product>();
        }
        public Person(string name, decimal money) : this()
        {
            Name = name;
            Money = money;
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
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.NegativeMoneyException);
                }
                money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag => (IReadOnlyCollection<Product>)bag;
        //наследява се от ICollection
        //предовратява използване на мейн функции в main method като Add,Remove,etc;
        public string BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                return String.Format(CannotAffordProductException, Name, product.Name);
            }
            Money -= product.Cost;
            bag.Add(product);
            return String.Format(SuccessfullyBoughtProduct, Name, product.Name);
        }
        public override string ToString()
        {
            string productOutput = Bag.Count > 0 ? String.Join(", ", Bag) : "Nothing bought";
            return $"{Name} - {productOutput}";
        }
    }
}
