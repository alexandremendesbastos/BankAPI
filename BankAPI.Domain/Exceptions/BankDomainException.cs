using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Exceptions
{
    public class BankDomainException : Exception
    {
        public BankDomainException()
        { }

        public BankDomainException(string message)
            : base(message)
        { }

        public BankDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
