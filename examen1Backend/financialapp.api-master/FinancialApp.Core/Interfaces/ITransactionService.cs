using FinancialApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.Interfaces
{
    public interface ITransactionService
    {
        ServiceResult<IReadOnlyList<Transaction>> GetLastTransactions();

        ServiceResult<Transaction> addTransaction(Transaction transaction, long id);

        double Income(long id);

        double Expense(long id);
    }
}
