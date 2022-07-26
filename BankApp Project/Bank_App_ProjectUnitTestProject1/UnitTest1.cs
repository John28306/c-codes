using BankApp_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bank_App_ProjectUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Funds_To_Balance()
        {
            //arrange
            var account = new BankAccount(1000);
            //act
            account.Add(500);
            //assert
            Assert.AreEqual(1500, account.Balance);
        }       

        [TestMethod]
        public void Withdraw_Funds_From_Balance()
        {
            //arrange
            var account = new BankAccount(1000);
            //act
            account.Withdraw(500);
            //assert
            Assert.AreEqual(500, account.Balance);
        }
       
        [TestMethod]
        public void Transfering_Funds_Update_Both_Account()
        {
            //arrange
            var account = new BankAccount(1000);
            var otheraccount = new BankAccount();
            //act
            account.TransferFundsTo(otheraccount,500);
            //assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otheraccount.Balance);

        }
        [TestMethod]
        public void Account_Balance_Is_Low()
        {
            //arrange
            var account = new BankAccount(100);
            //act
            var result =account.AccountBalanceIsLow();
            
            //assert
            Assert.IsTrue(result);

        }
    }
}
