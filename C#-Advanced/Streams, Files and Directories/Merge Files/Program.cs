using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../../FileOne.txt";
            string secondFileName = "../../../FileTwo.txt";

          
            var mergedList = new List<string>();

            var firstFileLines = File.ReadAllLines(firstFileName);
            var secondFileLines = File.ReadAllLines(secondFileName);

            foreach (var line in firstFileLines)
            {
                mergedList.Add(line);
            }

            foreach (var line in secondFileLines)
            {
                mergedList.Add(line);
            }

            string outputFilePath = "../../../Output.txt";

            File.WriteAllLines(outputFilePath, mergedList.OrderBy(x => x));
        }
    }
}
