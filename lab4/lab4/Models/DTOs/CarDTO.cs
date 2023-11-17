namespace lab4.Models.DTOs
{
    public class CarDTO
    {
        public Guid Id { get; set; }
        public string Brand { get; set; } = default!;

        public string LicensePlate { get; set; }
        public int Price  { get; set; }
    }
}
