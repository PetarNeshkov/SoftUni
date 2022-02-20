using Raiding.Contracts;
namespace Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual int Power { get; }

        public virtual string CastAbility()
        {
            return null;
        }
    }
}
