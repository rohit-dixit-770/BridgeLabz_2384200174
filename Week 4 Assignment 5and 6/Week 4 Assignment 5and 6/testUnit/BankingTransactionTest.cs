using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    internal class BankingTransactionTest
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance()
        {
            var account = new BankAccount(100);
            account.Deposit(50);
            Assert.AreEqual(150, account.GetBalance());
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenFundsAreSufficient()
        {
            var account = new BankAccount(100);
            bool success = account.Withdraw(50);
            Assert.IsTrue(success);
            Assert.AreEqual(50, account.GetBalance());
        }

        [Test]
        public void Withdraw_ShouldFail_WhenFundsAreInsufficient()
        {
            var account = new BankAccount(50);
            bool success = account.Withdraw(100);
            Assert.IsFalse(success);
            Assert.AreEqual(50, account.GetBalance());
        }

        [Test]
        public void Deposit_NegativeAmount_ShouldThrowException()
        {
            var account = new BankAccount(100);
            Assert.Throws<ArgumentException>(() => account.Deposit(-10));
        }

        [Test]
        public void Withdraw_NegativeAmount_ShouldThrowException()
        {
            var account = new BankAccount(100);
            Assert.Throws<ArgumentException>(() => account.Withdraw(-10));
        }
    }
}
