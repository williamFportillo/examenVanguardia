using FinancialApp.Core.Entities;
using FinancialApp.Core.Interfaces;
using FinancialApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository<Account>
    {
        private readonly FinancialAppContext _financialAppContext;

        public AccountRepository(FinancialAppContext financialAppContext)
        {
            _financialAppContext = financialAppContext;
        }
        public IReadOnlyList<Account> Get()
        {
            return _financialAppContext.Account.ToList(); ;
        }

        public Account getById(long id)
        {
            return _financialAppContext.Account.FirstOrDefault(a => a.Id == id);
        }
    }
}
