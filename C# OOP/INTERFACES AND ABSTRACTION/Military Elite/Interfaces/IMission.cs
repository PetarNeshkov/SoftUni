﻿
namespace MilitaryElite.Interfaces
{
    using Enumerations;
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
