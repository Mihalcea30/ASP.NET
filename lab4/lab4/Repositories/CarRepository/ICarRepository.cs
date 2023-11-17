using lab4.Models;

namespace lab4.Repositories.CarRepository
{
    public interface ICarRepository
    {
        Car FindByLicensePlate(string license);

        List<Car> FindAllActive();
    }
}
