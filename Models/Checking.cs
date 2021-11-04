using System;
using System.Collections.Generic;
using System.Text;

namespace BankExercise.Models
{
    public class Checking : Account
    {
        public Checking(string ownerName, float balance) : base(ownerName, balance)
        {
        }
    }
}
