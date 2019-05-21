using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class TourService : ITourService
    {
        private ITourRepository _tourRepository;
        private IMapper _mapper;

        public TourService(ITourRepository tourRepository, IMapper mapper)
        {
            _mapper = mapper;
            _tourRepository = tourRepository;
        }

        public Contracts.Tour CreateTour(Contracts.Tour tour)
        {
            Model.Tour efTour = _mapper.Map<Contracts.Tour, Model.Tour>(tour);
            efTour = _tourRepository.CreateTour(efTour);
            return _mapper.Map<Model.Tour, Contracts.Tour>(efTour);
        }

        public Contracts.Tour UpdateTour(Contracts.Tour tour)
        {
            Model.Tour efTour = _mapper.Map<Contracts.Tour, Model.Tour>(tour);
            _tourRepository.UpdateTour(efTour);
            return tour;
        }

        public ICollection<Contracts.Tour> GetTours()
        {
            return _mapper.Map<ICollection<Model.Tour>, ICollection<Contracts.Tour>>(_tourRepository.GetAllTours());
        }

        public Contracts.Tour GetTour(int tourId)
        {
            return _mapper.Map<Model.Tour, Contracts.Tour>(_tourRepository.GetTour(tourId));
        }

        public bool DeleteTour(int tourId)
        {
            return _tourRepository.DeleteTour(tourId);
        }
    }
}
