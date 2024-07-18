using BankAPI.Domain.Core.Models;
using BankAPI.Domain.Models.Account.Person.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Account.Person
{
    /// <summary>
    /// This class only exists because the EF core does not support many-to-many relationship with shadow table.
    /// https://github.com/dotnet/efcore/issues/1368
    /// When this issue is resolved, the propertie <see cref="Document.ScannedFiles"/> must be changed to <see cref="List{Storage}"/>.
    /// </summary>
    public class DocumentStorage : ValueObject
    {
        private Guid _storageId;
        internal DocumentStorage(Guid documentId, Guid storageId)
        {
            DocumentId = documentId;
            _storageId = storageId;
        }

        public Storage Storage { get; private set; }
        public Guid DocumentId { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Storage.Id;
        }
    }
}
