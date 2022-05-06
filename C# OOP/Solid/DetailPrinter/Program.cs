using DetailPrinter.Models;
using System;
using System.Collections.Generic;

namespace DetailPrinter
{
   public class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Employee");
            var manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
            var detailsPrinter = new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            Console.WriteLine(detailsPrinter.PrintDetails());
        }
    }
}
