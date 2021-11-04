using System;
using System.Collections.Generic;
using System.Text;

namespace BankExercise.Models
{
    public enum ACCOUNT_TYPE
    {
        Individual,
        Corporate
    }
    public class Investment : Account
    {
        public ACCOUNT_TYPE accountType { get; private set; }

        public Investment(string ownerName, float balance, ACCOUNT_TYPE type) : base(ownerName, balance)
        {
            accountType = type;
        }


        public override bool Withdraw(float amount)
        {
            if (accountType == ACCOUNT_TYPE.Individual && amount > 500)
            {                
                return false;                
            }
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }

            return false;
        }
    }
}
