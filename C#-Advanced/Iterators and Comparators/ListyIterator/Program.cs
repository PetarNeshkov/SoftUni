using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = new ListyIterator<string>();
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                if (input.Contains("Create"))
                {
                    string[] createCommand = input
                        .Split(new string[] { "Create", " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    for (int i = 0; i < createCommand.Length; i++)
                    {
                        listyIterator.Add(createCommand[i]);
                    }
                }
                else if (input=="Move")
                {
                    Console.WriteLine(listyIterator.Move()); 
                }
                else if (input=="Print")
                {
                    listyIterator.Print();
                }
                else if (input=="HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext()); 
                }
            }
        }
    }
}
