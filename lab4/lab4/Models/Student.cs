using lab4.Models.Base;

namespace lab4.Models
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
