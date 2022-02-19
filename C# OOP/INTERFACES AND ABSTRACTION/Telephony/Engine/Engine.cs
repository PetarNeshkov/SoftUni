using System;
using System.Linq;
using Telephony.Contracts;
using Telephony.Models;

namespace Telephony.Engine
{
    public class Engine
    {
        private ICallable callerForSmartphone;
        private ICallable callerForStationaryPhone;
        private IBrowsable browser;

        public Engine(IBrowsable browser)
        {
            this.callerForSmartphone =new SmartPhone();
            callerForStationaryPhone = new StationaryPhone();
            this.browser = browser;
        }

        public void Run()
        {
            var phoneNumbers = Console.ReadLine()
                .Split()
                .ToArray();

            var sites = Console.ReadLine()
                .Split()
                .ToArray();

            CallNumbers(phoneNumbers);
            BrowseSites(sites);
        }

        private void BrowseSites(string[] sites)
        {
            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(this.browser.Browse(site));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
        }

        private void CallNumbers(string[] phoneNumbers)
        {
            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(callerForStationaryPhone.Call(number));
                    }
                    else
                    {
                        Console.WriteLine(callerForSmartphone.Call(number));
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
        }
    }
}
