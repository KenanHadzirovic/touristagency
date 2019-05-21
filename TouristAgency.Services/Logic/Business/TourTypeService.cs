using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class TourTypeService : ITourTypeService
    {
        private ITourTypeRepository _tourTypeRepository;
        private IMapper _mapper;

        public TourTypeService(ITourTypeRepository tourTypeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _tourTypeRepository = tourTypeRepository;
        }

        public Contracts.TourType CreateTourType(Contracts.TourType tourType)
        {
            Model.TourType efTourType = _mapper.Map<Contracts.TourType, Model.TourType>(tourType);
            efTourType = _tourTypeRepository.CreateTourType(efTourType);
            return _mapper.Map<Model.TourType, Contracts.TourType>(efTourType);
        }

        public Contracts.TourType UpdateTourType(Contracts.TourType tourType)
        {
            Model.TourType efTourType = _mapper.Map<Contracts.TourType, Model.TourType>(tourType);
            _tourTypeRepository.UpdateTourType(efTourType);
            return tourType;
        }

        public ICollection<Contracts.TourType> GetTourTypes()
        {
            return _mapper.Map<ICollection<Model.TourType>, ICollection<Contracts.TourType>>(_tourTypeRepository.GetAllTourTypes());
        }

        public Contracts.TourType GetTourType(int tourTypeId)
        {
            return _mapper.Map<Model.TourType, Contracts.TourType>(_tourTypeRepository.GetTourType(tourTypeId));
        }

        public bool DeleteTourType(int tourTypeId)
        {
            return _tourTypeRepository.DeleteTourType(tourTypeId);
        }
    }
}
