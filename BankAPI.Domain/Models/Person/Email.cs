using BankAPI.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Person
{
    public class Email : ValueObject
    {
        private Email() { }
        public Email(string emailAddress)
        {
            EmailAddress = emailAddress.Trim().ToLowerInvariant();
        }

        public string EmailAddress { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return EmailAddress;
        }
    }
}
