﻿using System;
using System.Linq;
using System.Reflection;

namespace CodeTracker
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type authorAttributeType = typeof(AuthorAttribute);

            MethodInfo[] methodsByAuthor = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .SelectMany(t => t.GetMethods(
                    BindingFlags.Instance
                    | BindingFlags.Public
                    | BindingFlags.Static))
                .Where(m => m.GetCustomAttributes(authorAttributeType).Any())
                .ToArray();

            foreach (var method in methodsByAuthor)
            {
                var attributes = method.GetCustomAttributes<AuthorAttribute>();

                foreach (var attribute in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}
