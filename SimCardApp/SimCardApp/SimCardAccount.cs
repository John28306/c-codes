using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCardAccount
    {
      
        private double balance;
        private double databalance;

        public SimCardAccount()
        {
        }
        public SimCardAccount(double balance)
        {
            this.balance = balance;
        }

        
        public double Balance
        {
            get { return balance; }
        }
        public double Data
        {
            get { return databalance; }
        }

        public void Recharge(double amount)
        {
            if (amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance = balance + amount;
        }
        public void BuyData(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance = balance - amount;
            databalance = databalance + amount;
        }

        public void BorrowAirtime(double amount)
        {
            if (balance > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
           
            balance = balance + amount;
        }

        public void TransferAirtimeTo(SimCardAccount friendnumber, double amount)
        {
            if (friendnumber is null)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance = balance - amount;
            friendnumber.Recharge(amount);
        }
        public bool AirtimeIsLow()
        {
            if (Balance < 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }










    }

}
