using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
  [Test]
  public void DummyShouldLoseHealthWhenAttacked()
    {
        Dummy dummy = new Dummy(100, 100);

        dummy.TakeAttack(10);

        var expectedResult = 90;
        var actualresult = dummy.Health;

        Assert.AreEqual(expectedResult, actualresult);
    }
    [Test]
    public void DummyShouldThrowExceptionWhenAttacked()
    {
        Dummy dummy = new Dummy(0, 100);

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));

    }
    [Test]
    public void DeadDummyShouldGiveXp()
    {
        Dummy dummy = new Dummy(0, 50);
      
       var actualResult = dummy.GiveExperience();

        var expectedResult = 50;
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void AliveDummyShouldNotGiveXp()
    {
        Dummy dummy = new Dummy(100, 50);

        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());    
    }
}
