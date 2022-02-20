using Raiding.Globals;
using System;
namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
        }
        public override int Power => Constants.PaladinAndWarriorPower;
        public override string CastAbility()
        {
            return String.Format
                (Constants.StringOverrideRogueWarrior,GetType().Name,Name, Power);
        }
    }
}
