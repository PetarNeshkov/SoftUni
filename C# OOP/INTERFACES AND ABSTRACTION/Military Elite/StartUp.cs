
using MilitaryElite.Commands;
using MilitaryElite.Core;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CommandParser commandParser = new CommandParser();
            Engine engine = new Engine(commandParser);
            engine.Run();
        }
      
    }
}
