using System;
using System.Collections.Generic;
using System.Text;

namespace BankExercise.BusinessLogic
{
    //Future state would implement to keep track of different transactions
    public interface ITransactionRepository
    {
        public void Withdraw(float amount);
        public void Deposit();
        public void Transfer();
    }

    public class TransactionRepository : ITransactionRepository
    {
        public TransactionRepository()
        {

        }

        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(float amount)
        {
            throw new NotImplementedException();
        }
    }
}
