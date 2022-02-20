using Raiding.Globals;
using System;
namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
        }
        public override int Power => Constants.RogueAndDruidPower;
        public override string CastAbility()
        {
            return String.Format
                 (Constants.StringOverrideRogueWarrior, GetType().Name, Name, Power);
        }
    }
}
