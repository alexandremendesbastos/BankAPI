namespace BankAPI.Domain.Models.Person
{
    public enum CivilState
    {
        Married = 1,
        Single = 2,
        Widow = 3,
        LegalSeparation = 4,
        Divorced = 5,
        NonSpecified = 6
    }

    public static class CivilStateExtensions
    {
        public static CivilState GetCivilState(this int id)
        {
            return Enum.IsDefined(typeof(CivilState), id)
                ? (CivilState)id
                : throw new ArgumentException("Invalid CivilState id", nameof(id));
        }

        public static IEnumerable<CivilState> List() =>
            Enum.GetValues(typeof(CivilState)).Cast<CivilState>();
    }
}
