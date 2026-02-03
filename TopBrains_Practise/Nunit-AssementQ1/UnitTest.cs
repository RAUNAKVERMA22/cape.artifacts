using NUnit.Framework;
using System;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(100);
        account.Deposit(50);

        Assert.That(account.Balance, Is.EqualTo(150));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(100);

        Exception ex = Assert.Throws<Exception>(() => account.Deposit(-20))!;

        Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(200);
        account.Withdraw(80);

        Assert.That(account.Balance, Is.EqualTo(120));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(100);

        Exception ex = Assert.Throws<Exception>(() => account.Withdraw(150))!;

        Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
    }
}
