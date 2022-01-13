using NUnit.Framework;
using System.Linq;
using System;



public class DatabaseTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ConstructorShouldBeInitializedWith16Elements()
    {
        int[] numbers = Enumerable.Range(1, 16).ToArray();

        Database database = new Database(numbers);

        var expectedResult = 16;
        var actualResult = database.Count;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void ConstructorShouldThrowExceptionIfThereAreNot16Elements()
    {
        //TODO: Refactor this
        int[] numbers = Enumerable.Range(1, 10).ToArray();

        Database database = new Database(numbers);

        var expectedResult = 10;
        var actualResult = database.Count;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void AddOperatioinShouldAddElementAtNextFreeCell()
    {
        //Arrance
        int[] numbers = Enumerable.Range(1, 10).ToArray();
        Database database = new Database(numbers);

        //Act
        database.Add(5);
        var allElements = database.Fetch();

        //Assert
        var expectedValue = 5;
        var actualValue = allElements[10];

        Assert.AreEqual(expectedValue, actualValue);
    }

    [Test]
    public void AddOperationThrowExceptionIfElementsAreAbove16()
    {
        //Arrance
        int[] numbers = Enumerable.Range(1, 16).ToArray();
        Database database = new Database(numbers);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => database.Add(10));
    }

    [Test]
    public void RemoveOperationShouldSupportOnlyRemovingElementAtLastIndex()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 10).ToArray();
        Database database = new Database(numbers);

        //Act
        database.Remove();

        ////Assert
        var expectedResult = 9;
        var actualValue = database.Fetch()[8];

        var expectedCount = 9;
        var actualCount = database.Count;

        Assert.AreEqual(expectedResult, actualValue);
        Assert.AreEqual(expectedCount, actualCount);
    }

    [Test]
    public void RemoveOperationShouldThrowExceptionIfDatabaseIsEmpty()
    {
        //Arrange
        Database database = new Database();

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => database.Remove());
    }

    [Test]
    public void FetchShouldReturnAllElements()
    {
        //Arrange
        int[] numbers = Enumerable.Range(1, 5).ToArray();
        Database database = new Database(numbers);

        //Act
        var allItems = database.Fetch();

        //Assert
        int[] expectedValue = { 1, 2, 3, 4, 5 };

        CollectionAssert.AreEqual(expectedValue, allItems);
    }
}
