using System;
using System.Collections.Generic;
using BankAPI.Domain.Core.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public class AccountAttributes : ValueObject
    {
        private AccountAttributes() { }
        public AccountAttributes(string accountNumber, string cvv, bool isDigital, bool isActive)
        {
            AccountNumber = accountNumber;
            CVV = cvv;
            IsDigital = isDigital;
            IsActive = isActive;
        }
        public string AccountNumber { get; private set; }
        public string CVV { get; private set; }
        public bool IsDigital { get; private set; }
        public bool IsActive { get; private set; }
        public Agency Agency { get; private set; }
        public AccountTypes AccountType { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return AccountNumber;
        }
    }
    public enum AccountTypes
    {
        Salario = 0,
        Corrente = 1,
        Poupanca = 2,
        Universitaria = 3,
    }
}
