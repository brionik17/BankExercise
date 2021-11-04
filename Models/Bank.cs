using System;
using System.Collections.Generic;
using System.Text;

namespace BankExercise.Models
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
