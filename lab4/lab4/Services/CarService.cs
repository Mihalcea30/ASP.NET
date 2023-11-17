using AutoMapper;
using lab4.Models.DTOs;
using lab4.Repositories.CarRepository;

namespace lab4.Services
{
    public class CarService : ICarService
    {
        public ICarRepository _carRepository;
        public IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }


        public async Task<List<CarDTO>> GetAllCars()
        {
            var carList = await _carRepository.GetAllAsync();
            return _mapper.Map<List<CarDTO>>(carList);
        }

        public CarDTO GetCarByLicensePlate(string license)
        {
            var user = _carRepository.FindByLicensePlate(license);

            return _mapper.Map<CarDTO>(user);
        }
    }
}
