

namespace MilitaryElite.Interfaces
{
    using Enumerations;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
