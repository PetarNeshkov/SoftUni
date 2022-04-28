using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandType = inputTokens[0].ToLower();
            string[] commandArgs = inputTokens.Skip(1).ToArray();

            string result = string.Empty;

            //get commandTypes
            //create command Type instance
            //execute command
            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x=>x.Name.ToLower()==$"{commandType}Command".ToLower());

            ICommand instance = (ICommand)Activator.CreateInstance(type);

            result = instance.Execute(commandArgs);

            return result;
        }
    }
}
