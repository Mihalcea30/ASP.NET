using lab4.Data;
using lab4.Repositories.GenericRepository;
using lab4.Models;
using lab4.Helper.Extensions;

namespace lab4.Repositories.CarRepository
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
        {
        public CarRepository(Lab4Context lab4Context) : base(lab4Context)
            {
            }

            public List<Car> FindAllActive()
            {
                return _table.GetActiveCar().ToList();
            }

            public Car FindByLicensePlate(string license)
            {
                return _table.FirstOrDefault(u => u.License_Plate.Equals(license));
            }

    }
    }
