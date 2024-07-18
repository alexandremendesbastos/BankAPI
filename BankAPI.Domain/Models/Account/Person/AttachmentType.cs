namespace BankAPI.Domain.Models.Account.Person
{
    public enum AttachmentType
    {
        ResidenceAttachment = 1,
        CriminalHistory = 2,
        StudentRegistration = 3,
        CollegeRegistration = 4,
        PostGraduationRegistration = 5,
        HighSchoolRegistration = 6,
        WeddingCertificate = 7,
        BirthCertificate = 8,
        BirthDependentCertificate = 9,
        DependentStudentRegistration = 10,
        Curriculum = 11,
        Transcript = 12,
        Others = 13
    }

    public static class AttachmentTypeExtensions
    {
        public static AttachmentType GetAttachmentType(this int id)
        {
            return Enum.IsDefined(typeof(AttachmentType), id)
                ? (AttachmentType)id
                : throw new ArgumentException("Invalid AttachmentType id", nameof(id));
        }

        public static IEnumerable<AttachmentType> List() =>
            Enum.GetValues(typeof(AttachmentType)).Cast<AttachmentType>();
    }
}
