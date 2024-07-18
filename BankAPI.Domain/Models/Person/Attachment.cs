using BankAPI.Domain.Core.Models;

namespace BankAPI.Domain.Models.Person
{
    public class Attachment : Entity<Guid>
    {
        public AttachmentType AttachmentType { get; private set; }
        public List<AttachmentStorage> ScannedFiles { get; private set; }
        public DateTime? ExpiresOn { get; private set; }
        public DateTime UpdatedOn { get; private set; }
        public string Description { get; private set; }

        private Attachment() { }

        public Attachment(AttachmentType attachmentType, List<Guid> scannedFiles, DateTime? expiresOn, string description)
        {
            AttachmentType = attachmentType;
            UpdatedOn = DateTime.UtcNow;
            ExpiresOn = expiresOn;
            Description = description;
            ScannedFiles = new List<AttachmentStorage>();
            if (scannedFiles != null)
                scannedFiles.ForEach(f => ScannedFiles.Add(new AttachmentStorage(Id, f)));
        }
    }
}
