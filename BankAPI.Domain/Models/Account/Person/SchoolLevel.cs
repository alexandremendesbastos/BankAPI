using BankAPI.Domain.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankAPI.Domain.Models.Account.Person
{
    public class SchoolLevel : Enumeration
    {
        public static SchoolLevel ElementarySchool = new SchoolLevel(1, nameof(ElementarySchool));
        public static SchoolLevel UncompleteElementarySchool = new SchoolLevel(2, nameof(UncompleteElementarySchool));
        public static SchoolLevel HighSchool = new SchoolLevel(3, nameof(HighSchool));
        public static SchoolLevel UncompleteHighSchool = new SchoolLevel(4, nameof(UncompleteHighSchool));
        public static SchoolLevel College = new SchoolLevel(5, nameof(College));
        public static SchoolLevel UncommpleteCollege = new SchoolLevel(6, nameof(UncommpleteCollege));
        public static SchoolLevel PostGradutation = new SchoolLevel(7, nameof(PostGradutation));
        public static SchoolLevel UncompletePostGradutation = new SchoolLevel(8, nameof(UncompletePostGradutation));
        public static SchoolLevel MasterDegree = new SchoolLevel(9, nameof(MasterDegree));
        public static SchoolLevel UncompleteMasterDegree = new SchoolLevel(10, nameof(UncompleteMasterDegree));
        public static SchoolLevel Doctorate = new SchoolLevel(11, nameof(Doctorate));
        public static SchoolLevel UncompleteDoctorate = new SchoolLevel(12, nameof(UncompleteDoctorate));
        public static SchoolLevel PostDoctorate = new SchoolLevel(13, nameof(PostDoctorate));
        public static SchoolLevel UncompletePostDoctorate = new SchoolLevel(14, nameof(UncompletePostDoctorate));
        public static SchoolLevel NonEspecified = new SchoolLevel(15, nameof(NonEspecified));

        public SchoolLevel(int id, string name) : base(id, name) { }

        public static SchoolLevel Get(int id) => List().First(x => x.Id == id);
        public static IEnumerable<SchoolLevel> List() => new[]
        {   ElementarySchool,
            UncompleteElementarySchool,
            HighSchool,
            UncompleteHighSchool,
            College,
            UncommpleteCollege,
            PostGradutation,
            UncompletePostGradutation,
            MasterDegree,
            UncompleteMasterDegree,
            Doctorate,
            UncompleteDoctorate,
            PostDoctorate,
            UncompletePostDoctorate
        };
    }
}
