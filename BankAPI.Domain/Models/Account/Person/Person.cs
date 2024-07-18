using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection.Metadata;

namespace BankAPI.Domain.Models.Account.Person
{

    public class Person
    {
        private readonly List<Email> _emails;
        private readonly List<Phone> _phones;
        private readonly List<Document> _documents;
        private readonly List<Dependent> _dependents;
        private readonly List<Address> _address;
        private readonly List<Attachment> _attachments;
        private Person()
        { }
        public Person(string name, string socialName, string cpfNumber, string gender, PersonAttributes attributes, CivilState civilState, SchoolLevel schoolLevel)
        {
            Name = name;
            SocialName = socialName;
            CPFNumber = cpfNumber;
            Gender = gender;
            Attributes = attributes;
            CivilState = civilState;
            SchoolLevel = schoolLevel;

            _attachments = new List<Attachment>();
            _emails = new List<Email>();
            _phones = new List<Phone>();
            _documents = new List<Document>();
            _dependents = new List<Dependent>();
            _address = new List<Address>();
        }

        #region Properties
        public string Name { get; private set; }
        public string SocialName { get; private set; }
        public string DisplayName { get; private set; }
        public string CPFNumber { get; private set; }
        public SchoolLevel SchoolLevel { get; private set; }
        public CivilState CivilState { get; private set; }
        public string Gender { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public string BirthCity { get; private set; }
        public string BirthState { get; private set; }
        public string BirthCountry { get; private set; }
        public string Parent1Name { get; private set; }
        public string Parent1Gender { get; private set; }
        public string Parent2Name { get; private set; }
        public string Parent2Gender { get; private set; }
        public string PictureUrl { get; private set; }
        public IReadOnlyCollection<Address> Address => _address;
        public PersonAttributes Attributes { get; private set; }
        public IReadOnlyCollection<Attachment> Attachments => _attachments;
        public IReadOnlyCollection<Dependent> Dependents => _dependents;
        public IReadOnlyCollection<Document> Documents => _documents;
        public IReadOnlyCollection<Email> Emails => _emails;
        public IReadOnlyCollection<Phone> Phones => _phones;
        #endregion
    }

}
