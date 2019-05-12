using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class TourTypeRepository : ITourTypeRepository
    {
        private DataModel _context;

        TourTypeRepository(DataModel context)
        {
            _context = context;
        }


        /// <inheritdoc/>
        public bool DeleteTourType(int TourTypeId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<TourType> GetAllTourTypes()
        {
            return _context.TourType.ToList();
        }

        /// <inheritdoc/>
        public TourType GetTourType(int tourTypeId)
        {
            return _context.TourType.FirstOrDefault(x => x.TourTypeId == tourTypeId);
        }

        ///<inheritdoc/>
        public TourType CreateTourType(TourType tourType)
        {
            _context.TourType.Add(tourType);
            return tourType;
        }

        /// <inheritdoc/>
        public TourType UpdateTourType(TourType tourType)
        {
            return Update(_context.TourType.FirstOrDefault(x => x.TourTypeId == tourType.TourTypeId), tourType);
        }

        private TourType Update(TourType tourType, TourType newTourType)
        {
            tourType.TourTypeId = newTourType.TourTypeId;
            tourType.Price = newTourType.Price;
            tourType.PricePerDay = newTourType.PricePerDay;
            tourType.Name = newTourType.Name;
            tourType.MaxTourists = newTourType.MaxTourists;
            tourType.Location = newTourType.Location;

            return tourType;
        }
    }
}
