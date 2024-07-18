using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account.Person.Common
{
    public class Storage
    {
        public Guid Id { get; private set; }
        public string Filename { get; private set; }
        public string Extension { get; private set; }
        public string MimeType { get; private set; }
        public long Lenght { get; private set; }
        public string HashId { get; private set; }
        public string Url { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public string CreatedBy { get; private set; }
    }
}
