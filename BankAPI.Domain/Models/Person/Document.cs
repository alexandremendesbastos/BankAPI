using BankAPI.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Person
{
    public class Document : Entity<Guid>
    {
        private Document() { }

        public Document(DocumentType type, string number, DateTime? expiration, string attributes, List<Guid> scannedFiles)
        {
            Id = Guid.NewGuid();
            DocumentType = type;
            Number = number;
            Expiration = expiration;
            AttributesInfo = attributes;
            ScannedFiles = new List<DocumentStorage>();
            if (scannedFiles != null)
                scannedFiles.ForEach(f => ScannedFiles.Add(new DocumentStorage(Id, f)));
        }

        public DocumentType DocumentType { get; private set; }
        public string Number { get; private set; }
        public DateTime? Expiration { get; private set; }
        public string AttributesInfo { get; private set; }
        public List<DocumentStorage> ScannedFiles { get; private set; }
    }
}
