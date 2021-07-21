using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dc = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                if (!dc.ContainsKey(file.Extension))
                {
                    dc.Add(file.Extension, new Dictionary<string, double>());
                }
                dc[file.Extension].Add(file.Name, file.Length/1000.00);
            }
            using (StreamWriter writer =
                  new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\DirectoryTraversl.txt"))
            {
                foreach (var item in dc.OrderByDescending(f => f.Value.Count)
                   .ThenBy(item => item.Key))
                {
                    Console.WriteLine(item.Key);
                    foreach (var file in item.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"-- {file.Key} -{file.Value}kb");
                        writer.WriteLine($"-- {file.Key} -{file.Value}kb");
                    }
                }
            }           
        }
    }
}
