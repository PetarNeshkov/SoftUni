using Logger.Models.Enumerations;
using System;

namespace Logger.Models.Contracts.Layouts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        Level Level { get; }
    }
}
