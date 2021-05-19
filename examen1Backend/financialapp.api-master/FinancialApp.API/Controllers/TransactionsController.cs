using FinancialApp.API.Models;
using FinancialApp.Core;
using FinancialApp.Core.Entities;
using FinancialApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<TransactionDTO>> GetLastTransactions()
        {
            var transaction = transactionService.GetLastTransactions();
            if (transaction.ResponseCode == ResponseCode.Error)
            {
                return NotFound(transaction.Error);
            }

            return Ok(transaction.Result.Select(x => new TransactionDTO{
                Account = x.Account,
                Amount = x.Amount,
                Description = x.Description,
                TransactionDate = x.TransactionDate
            }));
        }

        [HttpPost]
        public ActionResult<TransactionDTO> addTransaction([FromBody] TransactionDTO t)
        {
            var entity = new Transaction
            {
                Account = t.Account,
                Amount = t.Amount,
                Description = t.Description,
                TransactionDate = DateTime.Now,
                
            };


            var account = entity.AccountId;
            var transaction = transactionService.addTransaction(entity, account);
            if (transaction.ResponseCode == ResponseCode.Error)
            {
                return BadRequest(transaction.Error);
            }
            return Ok(transaction);
        }

        [HttpGet("{id}")]

        public ActionResult<ResumenDTO> getResume(long id)
        {
            var income = transactionService.Income(id);
            var expense = transactionService.Expense(id);
            var total = income - expense;
            return Ok(new ResumenDTO { 
                income = income,
                expense = expense,
                total = total
            });
        }
    }

    
    }
