using AutoMapper;
using Data = TouristAgency.Data;
using Contracts = TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Model to Contracts
            CreateMap<Data.UserAccount, Contracts.UserAccount>().ReverseMap();
            CreateMap<Data.Employee, Contracts.Employee>()
                .ForMember(x => x.FullName, y => y.MapFrom(z => $"{z.FirstName} {z.LastName}"));
            CreateMap<Data.Feature, Contracts.Feature>().ReverseMap();
            CreateMap<Data.FeatureType, Contracts.FeatureType>().ReverseMap();
            CreateMap<Data.Hotel, Contracts.Hotel>().ReverseMap();
            CreateMap<Data.Privilege, Contracts.Privilege>().ReverseMap();
            CreateMap<Data.Role, Contracts.Role>().ReverseMap();
            CreateMap<Data.Tour, Contracts.Tour>().ReverseMap();
            CreateMap<Data.Tourist, Contracts.Tourist>().ReverseMap();
            CreateMap<Data.TourType, Contracts.TourType>().ReverseMap();

            // Contracts to Model
            CreateMap<Contracts.Employee, Data.Employee>();
        }
    }
}
