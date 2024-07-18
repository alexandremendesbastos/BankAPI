using BankAPI.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Transaction
{
    public class Deposit : Transaction
    {
        public Guid AccountId { get; private set; }
        /// <summary>
        /// Gets or sets the deposit slip image (if applicable).
        /// </summary>
        public byte[]? DepositSlipImage { get; set; }

        /// <summary>
        /// Gets or sets additional notes about the deposit.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets the source of the funds deposited.
        /// </summary>
        public string Source { get; }
        public string BankBranch { get; }
        public DepositStatus Status { get; private set; } = DepositStatus.Pending;
        public string ReferenceNumber { get; private set; }
        public DateTime? ClearingDate { get; private set; }
        public bool IsReversal { get; }
        public Deposit(decimal amount, string description, Guid accountId, string source, string bankBranch, string referenceNumber = null, decimal? transactionFee = null, bool isReversal = false)
            : base(amount, description, referenceNumber, transactionFee)
        {
            AccountId = accountId;
            Source = source;
            BankBranch = bankBranch;
            IsReversal = isReversal;
        }
        public void UpdateStatus(DepositStatus newStatus, DateTime? clearingDate = null)
        {
            if (!IsValidStatusTransition(newStatus))
            {
                throw new BankDomainException($"Invalid status transition from {Status} to {newStatus} for deposit.");
            }

            Status = newStatus;

            if (newStatus == DepositStatus.Completed)
            {
                ClearingDate = clearingDate ?? DateTime.UtcNow;
            }
        }
        private bool IsDepositValid()
        {
            return (Status == DepositStatus.Pending && Amount > 0 && !IsReversal) ||
                   (Status == DepositStatus.Pending && Amount < 0 && IsReversal);
        }
        private bool IsValidStatusTransition(DepositStatus newStatus)
        {
            switch (Status)
            {
                case DepositStatus.Pending:
                    return newStatus == DepositStatus.Completed || newStatus == DepositStatus.Failed || newStatus == DepositStatus.Cancelled;
                case DepositStatus.Completed:
                    return newStatus == DepositStatus.Failed; // Permite reversões
                default:
                    return false; // Nenhuma outra transição é permitida
            }
        }

    }
    public enum DepositStatus
    {
        Pending = 0,
        Completed = 1,
        Failed = 2,
        Cancelled = 3
    }
}
