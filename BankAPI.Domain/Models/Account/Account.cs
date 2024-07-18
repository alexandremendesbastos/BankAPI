using BankAPI.Domain.Core.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public class Account : Entity<Guid>, IAggregateRoot
    {
        private readonly List<AccountCards> _cards;
        private readonly List<Dependents> _dependents;

        public Account(Guid id, AccountAttributes attributes, Person.Person personId, decimal balance = 0)
        {
            Id = id;
            Attributes = attributes;
            PersonId = personId;
            Balance = balance;
            _cards = new List<AccountCards>();
            _dependents = new List<Dependents>();
            Balance = balance;
        }
        public Guid Id { get; private set; } = Guid.NewGuid();
        public decimal Balance { get; private set; }
        public Person.Person PersonId { get; private set; }
        public AccountAttributes Attributes { get; private set; }
        public IReadOnlyCollection<AccountCards> Cards => _cards;
        public IReadOnlyCollection<Dependents> Dependents=> _dependents;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
