using lab4.Models.Base;
using System.Data;

namespace lab4.Models
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public int Price { get; set; }

        public string License_Plate { get; set; }

    }
}
