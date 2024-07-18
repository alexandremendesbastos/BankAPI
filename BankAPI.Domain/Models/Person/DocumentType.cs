using BankAPI.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Domain.Models.Person
{
    public class DocumentType : Enumeration
    {
        public static DocumentType CPF = new DocumentType(1, nameof(CPF), "000.000.000-00", false);
        public static DocumentType RG = new DocumentType(2, nameof(RG), null, false);
        public static DocumentType CNH = new DocumentType(5, nameof(CNH), null, true);
        public static DocumentType PIS = new DocumentType(7, nameof(PIS), null, false);
        public static DocumentType Passaporte = new DocumentType(8, nameof(Passaporte), null, true);

        public DocumentType(int id, string name, string mask, bool expires) : base(id, name)
        {
            Mask = mask;
            Expires = expires;
        }

        public string Mask { get; set; }
        public bool Expires { get; set; }

        public static DocumentType Get(int id) => List().First(x => x.Id == id);
        public static IEnumerable<DocumentType> List() => new[]
        {
            CPF,
            RG,
            CNH,
            PIS,
            Passaporte
        };
    }
}