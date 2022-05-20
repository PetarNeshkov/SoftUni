using FizzBuzz.FolderContracts;

namespace FizzBuzz.Tests.Fake
{
    public class FakeConsoleWriter : IWriter
    {
        public void WriteLine(string input)
        {
            Result += input;
        }
        public string Result { get; set; }
    }
}
