using FinancialApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.Interfaces
{
    public interface ITransactionRepository<T>
    {
        IReadOnlyList<T> GetLastTransactions();

        T addTransaction(T transaction, Account account);

        IReadOnlyList<T> Income(long id);

        IReadOnlyList<T> Expenses(long id);

    }
}
