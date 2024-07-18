using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAPI.Domain.Models.Transaction
{
    public abstract class Transaction
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string ReferenceNumber { get; private set; }
        public DateTime Date { get; private set; } = DateTime.UtcNow;
        public decimal Amount { get; }
        public string Description { get; }
        public decimal? TransactionFee { get; }
        protected Transaction(decimal amount, string description, string referenceNumber = null, decimal? transactionFee = null)
        {
            Amount = amount;
            Description = description;
            ReferenceNumber = referenceNumber;
            TransactionFee = transactionFee;
        }
    }
}
