using FinancialApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.Interfaces
{
    public interface IAccountRepository<T>
    {
        IReadOnlyList<T> Get();

        T getById(long id);
    }
}
