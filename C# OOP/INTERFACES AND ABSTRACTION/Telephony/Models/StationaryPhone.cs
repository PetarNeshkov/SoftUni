using System;
using System.Linq;
using Telephony.Contracts;
using Telephony.Exceptions;
namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (number.All(x => char.IsDigit(x)))
            {
                return $"Dialing... {number}";
            }
            throw new ArgumentException
                (ExceptionMessages.InvalidNumberException);
        }
    }
}
