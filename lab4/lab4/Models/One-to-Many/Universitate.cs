using lab4.Models.Base;

namespace lab4.Models.One_to_Many
{
    public class Universitate:BaseEntity
    {
        public string? Name { get; set; }

        // relation 
        public ICollection<Facultate>? Facultati { get; set; }
    }
}
