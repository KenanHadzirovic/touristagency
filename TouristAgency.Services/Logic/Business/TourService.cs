using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class TourService : ITourService
    {
        private ITourRepository _tourRepository;

        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public Contracts.Tour CreateTour(Contracts.Tour tour)
        {
            Model.Tour efTour = Mapper.Map<Contracts.Tour, Model.Tour>(tour);
            efTour = _tourRepository.CreateTour(efTour);
            return Mapper.Map<Model.Tour, Contracts.Tour>(efTour);
        }

        public Contracts.Tour UpdateTour(Contracts.Tour tour)
        {
            Model.Tour efTour = Mapper.Map<Contracts.Tour, Model.Tour>(tour);
            _tourRepository.UpdateTour(efTour);
            return tour;
        }

        public ICollection<Contracts.Tour> GetTours()
        {
            return Mapper.Map<ICollection<Model.Tour>, ICollection<Contracts.Tour>>(_tourRepository.GetAllTours());
        }

        public Contracts.Tour GetTour(int tourId)
        {
            return Mapper.Map<Model.Tour, Contracts.Tour>(_tourRepository.GetTour(tourId));
        }

        public bool DeleteTour(int tourId)
        {
            return _tourRepository.DeleteTour(tourId);
        }
    }
}
