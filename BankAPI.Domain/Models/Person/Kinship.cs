using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAPI.Domain.Models.Person
{
    public enum Kinship
    {
        Avo = 1,
        Bisavo = 2,
        Bisneto = 3,
        Companheiro = 4,
        Conjuge = 5,
        Enteado = 6,
        ExConjuge = 7,
        Filho = 8,
        Irmao = 9,
        Neto = 10,
        Pai = 11,
        Mae = 12,
        Outros = 13
    }

    public static class KinshipExtensions
    {
        public static Kinship GetKinship(this int id)
        {
            return Enum.IsDefined(typeof(Kinship), id)
                ? (Kinship)id
                : throw new ArgumentException("Invalid Kinship id", nameof(id));
        }

        public static IEnumerable<Kinship> List() =>
            Enum.GetValues(typeof(Kinship)).Cast<Kinship>();
    }
}
