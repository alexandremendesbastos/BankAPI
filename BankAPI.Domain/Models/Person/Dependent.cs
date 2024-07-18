using BankAPI.Domain.Core.Models;
using System;

namespace BankAPI.Domain.Models.Person
{
    public class Dependent : Entity<Guid>
    {
        private Dependent()
        { }

        public Dependent(string name, string identityDocument, string gender,
            DateTime birthDate, Kinship kinship, Address homeAddress,
            string motherName, string fatherName,
            string birthCity, string birthState, string birthCountry)
        {
            Id = Guid.NewGuid();
            FullName = name;
            IdentityDocument = identityDocument;
            Gender = gender;
            BirthDate = birthDate;
            Kinship = kinship;
            HomeAddress = homeAddress;
            MotherName = motherName;
            FatherName = fatherName;
            BirthCity = birthCity;
            BirthState = birthState;
            BirthCountry = birthCountry;
        }

        public string FullName { get; private set; }
        public string IdentityDocument { get; private set; }
        public string Gender { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Kinship Kinship { get; private set; }
        public string MotherName { get; private set; }
        public string FatherName { get; private set; }
        public Address HomeAddress { get; private set; }
        public string BirthCity { get; private set; }
        public string BirthState { get; private set; }
        public string BirthCountry { get; private set; }
    }
}
