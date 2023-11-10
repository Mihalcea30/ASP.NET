using lab4.Models.Base;

namespace lab4.Models.One_to_One
{
    public class Materie:BaseEntity
    {
        public string? Name { get; set; }

        // relation
        public Profesor Profesor { get; set; }
        public Guid ProfesorId { get; set; }
    }
}
