using FinancialApp.Core.Entities;
using FinancialApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository<Account> _accountRepository;

        public AccountService(IAccountRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public ServiceResult<IReadOnlyList<Account>> GetAllAccounts()
        {
            var account = _accountRepository.Get();
            return ServiceResult<IReadOnlyList<Account>>.SuccessResult(account);
        }

        public Account GetById(long id)
        {
            var result = _accountRepository.getById(id);
            if (result == null)
            {
                return null;
            }

            return result;
        }
    }
}
