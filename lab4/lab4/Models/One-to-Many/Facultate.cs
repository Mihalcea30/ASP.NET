using lab4.Models.Base;

namespace lab4.Models.One_to_Many
{
    public class Facultate:BaseEntity
    {
        public string Name { get; set; }

        // relation
        public Universitate Universitate { get; set; }

        public Guid UniversitateId { get; set; }
    }
}
