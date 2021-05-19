using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialApp.API.Models;
using FinancialApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancialApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountsController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]

        public ActionResult<IReadOnlyList<AccountDTO>> GetAllAccounts()
        {
            var accounts = accountService.GetAllAccounts().Result.Select(x => new AccountDTO {
                Name = x.Name,
                Amount = x.Amount,
            });

            return Ok(accounts);
        }
    }
}
