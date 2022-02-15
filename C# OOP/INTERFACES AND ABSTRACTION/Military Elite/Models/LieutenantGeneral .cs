using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<ISoldier> privates;

        public LieutenantGeneral(
            int id,
            string firstName,
            string lastName,
            decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates
            => this.privates.AsReadOnly();

        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{base.ToString()}");
            result.AppendLine("Privates:");

            foreach (var @private in this.privates)
            {
                result.AppendLine($"  {@private}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
