
using System;
using System.IO;

namespace Logger.IOManagement
{
    public class FileWriter : IWriter
    {
        public FileWriter(string filepath)
        {
            FilePath = filepath;
        }
        public string FilePath { get;}
        public void Write(string text)
        {
            File.WriteAllText(FilePath,text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(FilePath, text + Environment.NewLine);
        }
    }
}
