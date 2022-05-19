using FakeAxeAndDummy.Contracts;
using Moq;

public class StartUp:IWeapon
{
    public int AttackPoints => throw new System.NotImplementedException();

    public int DurabilityPoints => throw new System.NotImplementedException();

    static void Main(string[] args)
    {
        //IWeapon weapon = new Axe(10, 10);
        //IAtackable target = new Dummy(10, 20);
        //Hero hero = new Hero("Pesho", weapon);

        //hero.Attack(target);
        Mock<IAtackable> target = new Mock<IAtackable>();
        target.Setup(x => x.GiveExperience()).Returns(20);
        Mock<IWeapon> weapon = new Mock<IWeapon>();
        System.Console.WriteLine($"Fake Attack: {weapon.Object.AttackPoints}");
        System.Console.WriteLine($"Fake Durability: {weapon.Object.DurabilityPoints}");

        int exp = target.Object.GiveExperience();
        System.Console.WriteLine(exp);
    }

    public void Attack(IAtackable target)
    {
        throw new System.NotImplementedException();
    }
}
