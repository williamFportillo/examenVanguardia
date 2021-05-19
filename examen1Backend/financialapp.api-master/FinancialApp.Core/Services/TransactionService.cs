using FinancialApp.Core.Entities;
using FinancialApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository<Transaction> transactionRepository;
        private readonly IAccountRepository<Account> accountRepository;

        public TransactionService(ITransactionRepository<Transaction> transactionRepository, IAccountRepository<Account> accountRepository)
        {
            this.transactionRepository = transactionRepository;
            this.accountRepository = accountRepository;
        }

        public ServiceResult<Transaction> addTransaction(Transaction transaction, long id)
        {
            var account = accountRepository.getById(id);

            if (account == null)
            {
                return ServiceResult<Transaction>.ErrorResult($"No se encontro la cuenta:{account}");
            }
            account.Amount += transaction.Amount;
            var result = transactionRepository.addTransaction(transaction, account);
            return ServiceResult<Transaction>.SuccessResult(result);
        }

        public double Expense(long id)
        {
            var result = transactionRepository.Expenses(id);
            var expenses = 0.0;
            foreach (var item in result)
            {
                expenses += item.Amount;
            }

            return expenses/24.13;
        }

        public ServiceResult<IReadOnlyList<Transaction>> GetLastTransactions()
        {
            var transaction = transactionRepository.GetLastTransactions();
            

           return ServiceResult<IReadOnlyList<Transaction>>.SuccessResult(transaction);
        }

        public double Income(long id)
        {
            var result =  transactionRepository.Income(id);
            var income = 0.0;
            foreach (var item in result)
            {
                income += item.Amount;
            }

            return income/24.13;
        }
    }
}
