using System;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../ZipDemo1","../../../ZipDemo2/ZipDemo2.zip");
            ZipFile.ExtractToDirectory("../../../ZipDemo2/ZipDemo2.zip","../../../Extract");
        }
    }
}
