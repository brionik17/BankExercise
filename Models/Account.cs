using System;
using System.Collections.Generic;
using System.Text;
using BankExercise.BusinessLogic;

namespace BankExercise.Models
{
    public abstract class Account
    {
        public Account(string ownerName, float balance)
        {
            this.ownerName = ownerName;
            this.balance = balance;
        }
        public string ownerName { get; set; }
        public float balance { get; set; }

        public void Deposit(float amount)
        {
            balance += amount;
        }
        public virtual bool Withdraw(float amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;

        }
        public bool Transfer(float amount, Account targetAccount)
        {
            if (amount <= balance)
            {
                targetAccount.balance += amount;
                return true;
            }

            return false;
        }
    }
}
