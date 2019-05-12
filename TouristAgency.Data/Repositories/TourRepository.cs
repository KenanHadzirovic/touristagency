using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class TourRepository : ITourRepository
    {
        private DataModel _context;

        TourRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteTour(int TourId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Tour> GetAllTours()
        {
            return _context.Tour.ToList();
        }

        /// <inheritdoc/>
        public Tour GetTour(int tourId)
        {
            return _context.Tour.FirstOrDefault(x => x.TourId == tourId);
        }

        /// <inheritdoc/>
        public Tour CreateTour(Tour tour)
        {
            _context.Tour.Add(tour);
            return tour;
        }

        /// <inheritdoc/>
        public Tour UpdateTour(Tour tour)
        {
            return Update(_context.Tour.FirstOrDefault(x => x.TourId == tour.TourId), tour);
        }

        private Tour Update(Tour tour, Tour newTour)
        {
            tour.TourId = newTour.TourId;
            tour.TouristId = newTour.TouristId;
            tour.HotelId = newTour.HotelId;
            tour.TourTypeId = newTour.TourTypeId;
            return tour;
        }
    }
}
