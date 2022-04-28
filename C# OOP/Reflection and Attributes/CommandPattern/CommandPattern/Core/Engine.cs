using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter _commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this._commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                string result = _commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
