using lab4.Models.DTOs;

namespace lab4.Services
{
    public interface ICarService
    {
        Task<List<CarDTO>> GetAllCars();

        CarDTO GetCarByLicensePlate(string license);
    }
}
