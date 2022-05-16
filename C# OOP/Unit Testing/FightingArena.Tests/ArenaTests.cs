
using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class ArenaTests
{
    private Arena arena;
    [SetUp]
    public void Setup()
    {
        arena = new Arena();
    }

    [Test]
    public void ConstructorWorkingPropietly()
    {
        Assert.IsNotNull(arena);
    }

    [Test]
    public void CountShouldWork()
    {
        Warrior warrior = new Warrior("Pesho", 199, 100);
        arena.Enroll(warrior);

        int expectedCount = 1;
        int actualCount = arena.Count;

        Assert.AreEqual(expectedCount, actualCount);
    }

    [Test]
    public void SuccessfullyAddedWarrior()
    {
        Warrior warrior = new Warrior("Pesho", 199, 100);
        arena.Enroll(warrior);

        bool isAny = arena.Warriors.Any(x => x.Name == "Pesho");
        Assert.IsTrue(isAny);
    }

    [Test]
    public void InvalidEnrollException()
    {
        Warrior warrior = new Warrior("Pesho", 199, 100);
        arena.Enroll(warrior);

        Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
    }

    [Test]
    public void SuccessfullyAttackedWarrior()
    {
        Warrior atacker = new Warrior("Pesho", 199, 100);
        Warrior defender = new Warrior("Ivan", 90, 90);

        arena.Enroll(atacker);
        arena.Enroll(defender);

        arena.Fight(atacker.Name, defender.Name);

        int expectedResultAttacker = 10;
        int expectedResultDefender = 0;

        Assert.AreEqual(expectedResultAttacker, atacker.HP);
        Assert.AreEqual(expectedResultDefender, defender.HP);
    }

    [Test]
    public void InvalidAttackerOrDefender()
    {
        Warrior warrior1 = new Warrior("Pesho", 199, 100);
        Warrior warrior2 = new Warrior("Ivan", 90, 90);


        Assert.Throws<InvalidOperationException>(
            () => arena.Fight(warrior1.Name, warrior2.Name));

    }
}

