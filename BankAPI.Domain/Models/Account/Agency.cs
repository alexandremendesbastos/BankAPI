using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account
{
    public class Agency()
    {
        public Guid Id { get; private set; }
        public bool IsPhisic { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
    }
}
