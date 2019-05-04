using AutoMapper;
using Data = TouristAgency.Data;
using Contracts = TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Data.User, Contracts.User>().ReverseMap();
        }
    }
}
