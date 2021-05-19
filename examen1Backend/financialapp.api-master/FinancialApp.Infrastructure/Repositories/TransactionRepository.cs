using FinancialApp.Core.Entities;
using FinancialApp.Core.Interfaces;
using FinancialApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository<Transaction>
    {
        private readonly FinancialAppContext financialAppContext;

        public TransactionRepository(FinancialAppContext financialAppContext)
        {
            this.financialAppContext = financialAppContext;
        }

        public Transaction addTransaction(Transaction transaction, Account account)
        {
            
            financialAppContext.Add(transaction);
            financialAppContext.Update(account);
            financialAppContext.SaveChanges();
            return transaction;
        }

        public IReadOnlyList<Transaction> Expenses(long id)
        {
            return financialAppContext.Transaction.Where(x => x.Amount < 0 && x.AccountId == id).ToList();
        }

        public IReadOnlyList<Transaction> GetLastTransactions()
        {
            return financialAppContext.Transaction.Take(5).OrderByDescending(x => x.TransactionDate).ToList();
        }

        public IReadOnlyList<Transaction> Income(long id)
        {
            return financialAppContext.Transaction.Where(x => x.Amount >= 0 && x.AccountId == id).ToList();
        }
    }
}
