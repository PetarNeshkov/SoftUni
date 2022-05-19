using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Tests.Fakes
{
    public class WeaponFake : IWeapon
    {
        public int AttackPoints => 10;

        public int DurabilityPoints => 10;

        public void Attack(IAtackable target)
        {
          
        }
    }
}
