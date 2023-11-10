using lab4.Models.Base;

namespace lab4.Models.One_to_One
{
    public class Profesor: BaseEntity
    {
        public string? Name { get; set; }

        public Materie Materie { get; set; }
        public Guid MaterieId { get; set; }
    }
}
