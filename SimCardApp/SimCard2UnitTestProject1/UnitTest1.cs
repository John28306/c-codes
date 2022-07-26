using SimCardApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimCard2UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Recharge_Account_Less_Than_Update_Balance()
        {
            //arrange
            var account = new SimCardAccount(0);
            //act
            account.Recharge(10000);
            //assert
            Assert.AreEqual(10000,account.Balance);
        }
        [TestMethod]
        public void Buy_Data_Update_Balance()
        {
            //arrange
            var account = new SimCardAccount(1000);
            //act
            account.BuyData(500);
            //assert
            Assert.AreEqual(500, account.Balance);
        }
        [TestMethod]
        public void Borrow_Airtime_Update_Balance()
        {
            //arrange
            var account = new SimCardAccount(0);
            //act
            account.BorrowAirtime(500);
            //assert
            Assert.AreEqual(500, account.Balance);
        }
        [TestMethod]
        public void Transfer_Airtime_To()
        {
            //arrange
            var account = new SimCardAccount(1000);
            var friendnumber = new SimCardAccount(0);

            //act
            account.TransferAirtimeTo(friendnumber,500);
            //assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, friendnumber.Balance);

        }
        [TestMethod]
        public void Airtime_Is_Low()
        {
            //arrange
            var account = new SimCardAccount(10);

            //act
            var result=account.AirtimeIsLow();
            //assert
            Assert.IsTrue(result);

        }
    }
}
