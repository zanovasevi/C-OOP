using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void WeaponShouldLoseDurabilityAfterAttack()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);
        Axe axe = new Axe(10, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        var expecterResult = 9;
        var actualResult = axe.DurabilityPoints;

        Assert.AreEqual(expecterResult, actualResult);
    }

    [Test]
    public void AttackShouldTrowInvalidOperationExcWhenAxeDurabilityIsBeloweZero()
    {
        //Arrange
        Dummy dummy = new Dummy(10, 10);
        Axe axe = new Axe(20, 0);

        //Act - Assert
        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
    }
}
