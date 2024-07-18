using BankAPI.Domain.Core.Models;
using BankAPI.Domain.Models.Account.Person;
using BankAPI.Domain.Models.Person;
using System;

namespace BankAPI.Domain.Models.Account.Person
{
    public class Dependent : Entity<Guid>
    {
        private Dependent()
        { }

        public Dependent(string name, string rg, string cpf, string gender, DateTime birthDate, Kinship kinship, Address homeAddress, string parent1Name, string parent1Gender, string parent2Name, string parent2Gender, string birthCity, string birthState, string birthCountry)
        {
            Id = Guid.NewGuid();
            FullName = name;
            RG = rg;
            CPF = cpf;
            Gender = gender;
            BirthDate = birthDate;
            Kinship = kinship;
            HomeAddress = homeAddress;

            Parent1FullName = parent1Name;
            Parent1Gender = parent1Gender;
            Parent2FullName = parent2Name;
            Parent2Gender = parent2Gender;
            BirthCity = birthCity;
            BirthState = birthState;
            BirthCountry = birthCountry;
        }

        public string FullName { get; private set; }
        public string RG { get; private set; }
        public string CPF { get; private set; }
        public string Gender { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Kinship Kinship { get; private set; }
        public string Parent1FullName { get; private set; }
        public string Parent1Gender { get; private set; }
        public string Parent2FullName { get; private set; }
        public string Parent2Gender { get; private set; }
        public Address HomeAddress { get; private set; }
        public string BirthCity { get; private set; }
        public string BirthState { get; private set; }
        public string BirthCountry { get; private set; }
    }
}
