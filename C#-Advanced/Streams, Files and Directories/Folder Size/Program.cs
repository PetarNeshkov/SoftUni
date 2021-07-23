using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPatch = Console.ReadLine();
            //D:\SoftUni-Fund\Advanced\Streams, Files and Directories\Slice a File
            string[] files = Directory.GetFiles(directoryPatch);
            double sum = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName}  --> {info.Length} bytes");
                sum += info.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
