using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;
        public Engine()
        {
            people = new List<Person>();
            products = new List<Product>();
        }
        public void Run()
        {
            //Place business logic here
            try
            {
                ParsePeopleInput();
                ParseProductInput();
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split().ToArray();

                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];

                    Person person = people.FirstOrDefault(p => p.Name == personName);
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void ParsePeopleInput()
        {
            string[] peoplenArg = Console.ReadLine().Split(";");
            foreach (var personArg in peoplenArg)
            {
                string[] personArgs = personArg.Split("=");

                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);

                Person person = new Person(personName, personMoney);
                people.Add(person);
            }
        }
        private void ParseProductInput()
        {
            string[] productsArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var productArg in productsArgs)
            {
                string[] productArgs = productArg.Split("=");

                string productName = productArgs[0];
                decimal productCost = decimal.Parse(productArgs[1]);

                Product product = new Product(productName, productCost);
                products.Add(product);
            }
        }
    }
}

