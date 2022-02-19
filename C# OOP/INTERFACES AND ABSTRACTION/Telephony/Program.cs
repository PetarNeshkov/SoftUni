using Telephony.Contracts;
using Telephony.Models;
using Telephony.Engine;

public class StartUp
{
    public static void Main()
    {
        IBrowsable browser = new SmartPhone();
        Engine engine = new Engine(browser);
        engine.Run();
    }
}

