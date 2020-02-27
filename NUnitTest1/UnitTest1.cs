using System;
using NUnit.Framework;

[TestFixture]
public class Tester
{
    private double epsilon = 1e-6;

    [Test]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);
        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }

    [Test]
    public void AccountCannotOverstep()
    {
        Account account = new Account(20);
        var r = account.Withdraw(30);
        Assert.AreEqual(0, account.Balance, epsilon);
        Assert.IsFalse(r);
    }

    [Test]
    public void DepositCannotHaveNegative()
    {
        Account account = new Account(20);

        var r = account.Deposit(-10);
        Assert.AreEqual(0, account.Balance, epsilon);
        Assert.IsFalse(r);

    }
    [Test]
    public void DepositCanHavePositive()
    {
        Account account = new Account(20);

        Assert.IsTrue(account.Deposit(10));
    }

    [Test]
    public void WithdrawCannotHaveNegative()
    {
        Account account = new Account(20);
        var r = account.Withdraw(-30);
        Assert.AreEqual(0, account.Balance, epsilon);
        Assert.IsFalse(r);
    }
    [Test]
    public void WithdrawCanHavePositive()
    {
        Account account = new Account(20);
        var r = account.Withdraw(10);
        Assert.AreEqual(-10, account.Balance, epsilon);
        Assert.IsTrue(r);
    }


    [Test]
    public void DepositWorks()
    {
        Account account = new Account(20);
        var r = account.Deposit(10);
        Assert.AreEqual(10, account.Balance, epsilon);
        Assert.IsTrue(r);
    }
    [Test]
    public void WithdrawWorks()
    {
        Account account = new Account(20);
        account.Deposit(10);
        var r = account.Withdraw(5);
        Assert.AreEqual(5, account.Balance, epsilon);
        Assert.IsTrue(r);
    }
}