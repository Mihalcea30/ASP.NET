using lab4.Models;
using lab4.Models.DTOs;
using AutoMapper;

namespace lab4.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>()
                .ForMember(ud => ud.Brand,
                opts => opts.MapFrom(u => u.License_Plate));
        }

  
    }
}
