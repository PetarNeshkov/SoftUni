using System;
using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class SmartPhone : IBrowsable, ICallable
    {
        public string Call(string number)
        {
            if (number.Any(x => char.IsLetter(x)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberException);
            }

            return $"Calling... {number}";
        }

        public string Browse(string site)
        {
            if (site.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidUrlException);
            }

            return $"Browsing: {site}!";
        }
    }
}


