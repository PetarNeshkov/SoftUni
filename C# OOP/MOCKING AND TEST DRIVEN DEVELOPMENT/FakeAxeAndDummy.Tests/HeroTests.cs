using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Tests.Fakes;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExperience()
    {
        Mock<IAtackable> fakeTarget = new Mock<IAtackable>();
        fakeTarget.Setup(f => f.GiveExperience()).Returns(20);
        fakeTarget.Setup(f => f.IsDead()).Returns(true);

        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
        //IAtackable fakeTarget = new AttackableFake();
        // IWeapon weapon = new WeaponFake();
        //Hero hero = new Hero("Pesho", weapon);

        //hero.Attack(fakeTarget);

        Hero hero = new Hero("Pesho", fakeWeapon.Object);

        hero.Attack(fakeTarget.Object);

        Assert.AreEqual(20, hero.Experience);
    }
}