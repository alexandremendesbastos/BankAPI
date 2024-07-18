using BankAPI.Domain.Core.Models;

namespace BankAPI.Domain.Models.Account.Person
{
    public class Address : ValueObject
    {
        private Address() { }
        public Address(string address1, string address2, string zipCode, string city, string state, string country, AddressType type)
        {
            Address1 = address1;
            Address2 = address2;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
        }

        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string Address3 { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public AddressType Type { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Address1;
            yield return Address2;
            yield return Address3;
            yield return ZipCode;
            yield return City;
            yield return State;
            yield return Country;
        }
    }

    public enum AddressType
    {
        Home,
        Mailing
    }
}
