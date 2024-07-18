using BankAPI.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Person
{
    public class PersonAttributes : ValueObject
    {
        private PersonAttributes() { }

        public PersonAttributes(bool bloodDonor, bool physicalDeficiency, SkinColor skinColor)
        {
            SkinColor = skinColor;
            BloodDonor = bloodDonor;
            PhysicalDeficiency = physicalDeficiency;
        }

        public SkinColor SkinColor { get; private set; }
        public bool BloodDonor { get; private set; }
        public bool PhysicalDeficiency { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return SkinColor;
            yield return BloodDonor;
            yield return PhysicalDeficiency;
        }
    }
}
