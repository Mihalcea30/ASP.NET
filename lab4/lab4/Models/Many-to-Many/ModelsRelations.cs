namespace lab4.Models.Many_to_Many
{
    public class ModelsRelations
    {
        public Guid BobocId { get; set; }
        public Boboc Boboc { get; set; }

        public Guid AsociatieId { get; set; }
        public Asociatie Asociatie { get; set; }
    }
}
