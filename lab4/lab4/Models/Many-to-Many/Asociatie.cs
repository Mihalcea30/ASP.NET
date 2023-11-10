using lab4.Models.Base;

namespace lab4.Models.Many_to_Many
{
    public class Asociatie : BaseEntity {
        public string? Name { get; set; }
 
    public ICollection<ModelsRelations> ModelsRelations { get; set; }
}
}
