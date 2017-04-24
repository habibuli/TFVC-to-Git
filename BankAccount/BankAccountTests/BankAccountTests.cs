using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void BankAccountTest()
        {
            string customerName = "Mr. Bryan Walton";
            double balance = 15.01;
            BankAccount target = new BankAccount(customerName, balance);
            BankAccount.accountType actual;
            actual = target.GetAccountType;
            Assert.AreEqual(actual, BankAccount.accountType.Platinum);
        }

        [TestMethod()]
        public void BankAccountTest1()
        {
            string customerName = "Mr. Bryan Walton";
            double balance = 14.99;
            BankAccount target = new BankAccount(customerName, balance);
            BankAccount.accountType actual;
            actual = target.GetAccountType;
            Assert.AreEqual(actual, BankAccount.accountType.Gold);
        }
    }
}