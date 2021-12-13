using System;
using System.IO;

namespace Files_and_streams_with_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine(); //"C:"; трие всимко от С и става вирус
            GetDirectoeySize(directoryPath,0);
            //D:\SoftUni-Fund\Advanced\Bonus exercises\New folder - example input
        }

        static double GetDirectoeySize(string directoryPath,int identation)
        {
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;

            string[] directories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"{new string(' ', identation)}{directories[i]}");
                sum += GetDirectoeySize(directories[i],identation+5);
                //Directory.Delete(directories[i]); изтрива всички директории
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{new string ('-',identation)}{info.Name} --> {info.Length} bytes");
                sum += info.Length;
                //File.Delete(files[i]); изтрива всички папки
            }
            return sum; 
        }
    }
}
