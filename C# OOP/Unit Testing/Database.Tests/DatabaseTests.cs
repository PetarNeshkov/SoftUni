using NUnit.Framework;
using System;
using System.Linq;




[TestFixture]
public class DatabaseTests
{
    [Test]
    public void DatabaseCountShouldBE16integersLong()
    {
        int[] numbers = Enumerable.Range(1, 16).ToArray();
        Database.Database database = new Database.Database(numbers);

        int excpectedCount = 16;
        int actualCount = database.Count;
        Assert.AreEqual(excpectedCount, actualCount);
    }
    [Test]
    public void DatabaseCountShouldThroExceptionIfItIsNot16integersLong()
    {
        int[] numbers = Enumerable.Range(1, 15).ToArray();
        Database.Database database = new Database.Database(numbers);

        int excpectedCount = 16;
        int actualCount = database.Count;
        Assert.AreNotSame(excpectedCount, actualCount);
    }
    [Test]
    public void ShouldAddElementAtNextFreeCell()
    {
        int[] numbers = Enumerable.Range(1, 10).ToArray();
        Database.Database database = new Database.Database(numbers);

        database.Add(5);

        int expectedCount = 11;
        int actualCount = database.Count;
        Assert.AreEqual(expectedCount, actualCount);

        int[] allElements = database.Fetch();

        int expectedResult = 5;
        int actualResult = allElements[10];

        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void ShouldThrowExceptionIfAddElementAtCell()
    {
        int[] numbers = Enumerable.Range(1, 16).ToArray();
        Database.Database database = new Database.Database(numbers);

        Assert.Throws<InvalidOperationException>(() => database.Add(4));
    }
    [Test]
    public void ShouldRemoveElementAtLastIndex()
    {
        int[] numbers = Enumerable.Range(1, 10).ToArray();
        Database.Database database = new Database.Database(numbers);

        database.Remove();

        int expectedCount = 9;
        int actualCount = database.Count;

        Assert.AreEqual(expectedCount, actualCount);

        int expectedResult = 9;
        int actualResult = database.Fetch()[8];
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void ShouldRemoveThrowExceotionForElementAtLastIndex()
    {
        Database.Database database = new Database.Database();

        Assert.Throws<InvalidOperationException>(() => database.Remove());
    }
    [Test]
    public void FetchMethodShouldReturnElementsInTheArray()
    {
        int[] numbers = Enumerable.Range(1, 5).ToArray();
        Database.Database database = new Database.Database(numbers);

        int[] allItems = database.Fetch();

        int[] expectedValue = { 1, 2, 3, 4, 5 };

        CollectionAssert.AreEqual(expectedValue, allItems);
    }

}
