using BankAPI.Domain.Core.Models;
using BankAPI.Domain.Models.Account.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public class Account : Entity<Guid>, IAggregateRoot
    {
        private readonly List<Cards> _cards;
        private readonly List<Dependents> _dependents;

        public Account(Guid id, AccountAttributes attributes, Person.Person person, decimal balance = 0)
        {
            Id = id;
            Attributes = attributes;
            Person = person;
            Balance = balance;
            _cards = new List<Cards>();
            _dependents = new List<Dependents>();
            Balance = balance;
        }
        public Guid Id { get; private set; } = Guid.NewGuid();
        public decimal Balance { get; private set; }
        public Person.Person Person { get; private set; }
        public AccountAttributes Attributes { get; private set; }
        public IReadOnlyCollection<Cards> Cards => _cards;
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
