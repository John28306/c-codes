using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_Project
{
        public class BankAccount
        {
            private double balance;

            public BankAccount()
            {
            }
            public BankAccount(double balance)
            {
                this.balance = balance;
            }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public double Balance
            {
                get { return balance; }
            }

            public void Add(double amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance = balance + amount;
            }
            public void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance -= amount;
            }

            public void TransferFundsTo(BankAccount otheraccount, double amount)
            {
                if (otheraccount is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                Withdraw(amount);
                otheraccount.Add(amount);
            }

            public bool AccountBalanceIsLow()
            {
                if (Balance <= 100)
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
