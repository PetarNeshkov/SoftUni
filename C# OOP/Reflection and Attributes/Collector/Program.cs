using System;

namespace StartUp
{
   public class Stealer
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
