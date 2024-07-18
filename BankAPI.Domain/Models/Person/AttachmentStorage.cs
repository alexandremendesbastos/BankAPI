using BankAPI.Domain.Core.Models;
using BankAPI.Domain.Models.Person.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Person
{
    public class AttachmentStorage : ValueObject
    {
        private Guid _storageId;
        internal AttachmentStorage(Guid attachmentId, Guid storageId)
        {
            AttachmentId = attachmentId;
            _storageId = storageId;
        }

        public Storage Storage { get; private set; }
        public Guid AttachmentId { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Storage.Id;
        }
    }
}
