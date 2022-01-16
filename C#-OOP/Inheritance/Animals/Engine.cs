using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Engine
    {
        public void Run()
        {
            string input;
            List<Animal> animals = new List<Animal>();
            while ((input = Console.ReadLine()) != "Beast!")
            {

                Animal animal = null;
                try
                {
                    var animalInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    var animalName = animalInfo[0];
                    var animalAge = int.Parse(animalInfo[1]);
                    var animalGenger = animalInfo[2];



                    if (input == "Dog")
                    {
                        animal = new Dog(animalName, animalAge, animalGenger);

                    }
                    else if (input == "Cat")
                    {
                        animal = new Cat(animalName, animalAge, animalGenger);

                    }
                    else if (input == "Frog")
                    {
                        animal = new Frog(animalName, animalAge, animalGenger);
                    }
                    else if (input == "Kitten")
                    {
                        animal = new Kitten(animalName, animalAge);

                    }
                    else if (input == "Tomcat")
                    {
                        animal = new Tomcat(animalName, animalAge);

                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                animals.Add(animal);
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
