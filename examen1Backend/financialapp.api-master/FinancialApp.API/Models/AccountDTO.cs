using FinancialApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApp.API.Models
{
    public class AccountDTO
    {
        public string Name { get; set; }

        public double Amount { get; set; }
    }
}
