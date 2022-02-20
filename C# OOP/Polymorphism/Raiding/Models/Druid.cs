using Raiding.Globals;
using System;
namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
        }

        public override int Power =>Constants.RogueAndDruidPower;
        public override string CastAbility()
        {
           return String.Format
                (Constants.StringOverrideDruidPaladin,GetType().Name,Name,Power);
        }
    }
}
