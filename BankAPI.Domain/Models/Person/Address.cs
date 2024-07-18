using BankAPI.Domain.Core.Models;

namespace BankAPI.Domain.Models.Person
{
    public class Address : ValueObject
    {
        private Address() { }
        public Address(string personAddress, string zipCode, string city, string state, string country, AddressType type)
        {
            PersonAddress = personAddress;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
        }

        public string PersonAddress { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public AddressType Type { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return PersonAddress;
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
